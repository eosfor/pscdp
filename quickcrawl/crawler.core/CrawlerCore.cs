namespace quickcrawl.core;

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks.Dataflow;
using System.Collections.Concurrent;
using System.Collections.Generic;
using PSGraph.Model;

public class QuickCrawler
{
    private ActionBlock<CrawlTarget>? _messageQueue;
    private CancellationTokenSource _shouldCancel = new CancellationTokenSource();
    private readonly ConcurrentDictionary<string, int> _visited = new(StringComparer.OrdinalIgnoreCase);
    private ConcurrentBag<ProcessedUrlData> _capturedEvents = new ConcurrentBag<ProcessedUrlData>();
    private ILogger<QuickCrawler> _logger;
    private PSGraph.Model.PsBidirectionalGraph _graph = new PSGraph.Model.PsBidirectionalGraph();

    public List<ProcessedUrlData> CapturedEvents => _capturedEvents.ToList();
    public PsBidirectionalGraph Graph => _graph;

    private Uri _baseUri;

    // Configuration parameters
    //TODO: make these configurable via constructor or properties or from outside
    private int _maxDepth = 10;
    private int _maxReachedDepth = 0;

    private int _maxDegreeOfParallelism = 4;
    private int _boundedCapacity = 1000;

    public ConcurrentDictionary<string, int> VisitedUrls => _visited;

    public QuickCrawler(ILogger<QuickCrawler>? logger = null)
    {
        _logger = logger ?? LoggerFactory
            .Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Debug))
            .CreateLogger<QuickCrawler>();

        _messageQueue = new ActionBlock<CrawlTarget>(ProcessUrl, new ExecutionDataflowBlockOptions
        {
            MaxDegreeOfParallelism = _maxDegreeOfParallelism,
            CancellationToken = _shouldCancel.Token,
            BoundedCapacity = _boundedCapacity
        });

        _messageQueue.Completion.ContinueWith(t =>
        {
            if (t.IsFaulted)
            {
                _logger.LogError(t.Exception, "An error occurred while processing the message queue.");
            }
            else
            {
                _logger.LogInformation("Message queue processing completed successfully.");
            }
        }, TaskContinuationOptions.ExecuteSynchronously);
        _logger.LogInformation("QuickCrawler initialized.");
    }


    public void StartCrawling(string Url, int maxDepth = 10)
    {
        _baseUri = new Uri(Url);
        _maxDepth = maxDepth;
        _messageQueue?.Post(new CrawlTarget(Url, 0));
    }

    public void StopCrawling()
    {
        _shouldCancel.Cancel();
    }

    public async Task WaitForCompletionAsync()
    {
        if (_messageQueue != null)
        {
            await _messageQueue.Completion;
        }
    }


    // Method to process incoming URLs for the ActionBlock
    private async Task ProcessUrl(CrawlTarget target)
    {
        if (target.Depth >= _maxDepth)
        {
            _logger.LogInformation("Reached maximum depth for URL: {Url}", target.Url);
            //_messageQueue?.Complete();
            return;
        }
        _logger.LogInformation("Processing URL: {Url} at depth {Depth}", target.Url, target.Depth);
        if (_visited.ContainsKey(target.Url))
        {
            _logger.LogInformation("URL already visited, skipping processing: {Url}", target.Url);
            return;
        }

        int nextDepth = 0;
        try
        {
            using var processor = new PageProcessor(target.Url);
            var links = await processor.ProcessPageAsync();
            var events = processor.CapturedEvents;

            var processedData = new ProcessedUrlData(target.Url, events);
            _capturedEvents.Add(processedData);

            var graphSourceNode = new PSVertex(target.Url);
            _graph.AddVertex(graphSourceNode);

            foreach (var rawLink in links)
            {
                var normalizedLink = NormalizeLink(rawLink);
                nextDepth = IsInternalLink(normalizedLink, _baseUri) ? target.Depth : target.Depth + 1;

                if (_visited.ContainsKey(normalizedLink))
                {
                    _logger.LogInformation("URL already visited, skip adding a task for processing: {Url}", normalizedLink);
                    continue;
                }

                _messageQueue?.Post(new CrawlTarget(normalizedLink, nextDepth));

                var newVertex = new PSVertex(normalizedLink);
                var newEdge = new PSEdge(graphSourceNode, newVertex, new PSEdgeTag("CrawlEdge"));

                var addOpResult = _graph.AddVertex(newVertex);
                _logger.LogInformation("Adding vertex {v}: {result}", newVertex, addOpResult);

                addOpResult = _graph.AddEdge(newEdge);
                _logger.LogInformation("Adding edge from {Source} to {Target}: {result}", graphSourceNode, newVertex, addOpResult);
            }

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Processing URL: {Url} failed with: {exception}", target.Url, ex.Message);
            return;
        }
        finally
        {
            _visited.TryAdd(target.Url, nextDepth);
        }

        int prev;
        do
        {
            prev = _maxReachedDepth;
            if (target.Depth <= prev)
                break;
        }
        while (Interlocked.CompareExchange(ref _maxReachedDepth, target.Depth, prev) != prev);

        _logger.LogInformation("Finished processing URL: {Url} at depth {Depth}", target.Url, target.Depth);
        _logger.LogInformation("Max reached depth {Depth}", _maxReachedDepth);
    }

    private bool IsInternalLink(string link, Uri baseUri)
    {
        if (!Uri.TryCreate(link, UriKind.Absolute, out var uri))
            return false;

        return uri.Host.Equals(baseUri.Host, StringComparison.OrdinalIgnoreCase);
    }

    private string NormalizeLink(string url)
    {
        if (Uri.TryCreate(url, UriKind.Absolute, out var uri))
            return uri.GetLeftPart(UriPartial.Path).TrimEnd('/');
        return url;
    }

    public void Dispose()
    {
        _shouldCancel?.Dispose();
    }
}
