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
    private readonly ConcurrentDictionary<string, int> _planned = new(StringComparer.OrdinalIgnoreCase);
    private ConcurrentBag<ProcessedUrlData> _capturedEvents = new ConcurrentBag<ProcessedUrlData>();
    private ILogger _logger;
    private PSGraph.Model.PsBidirectionalGraph _graph = new PSGraph.Model.PsBidirectionalGraph();

    public List<ProcessedUrlData> CapturedEvents => _capturedEvents.ToList();
    public PsBidirectionalGraph Graph => _graph;

    private Uri _baseUri = default!;
    private int _pendingCount;
    private readonly object _dequeueLock = new object();
    public event Action<int, int>? ProgressChanged;

    // Configuration parameters
    //TODO: make these configurable via constructor or properties or from outside

    // one link away to the outside from the base URL
    private int _maxDepth = 1;
    private int _maxReachedDepth = 0;

    private int _maxDegreeOfParallelism = 4;
    private int _boundedCapacity = 2000;

    public ConcurrentDictionary<string, int> VisitedUrls => _visited;

    public QuickCrawler(ILogger? logger = null)
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


    public void StartCrawling(string Url, int maxDepth = 1, int maxDegreeOfParallelism = 4)
    {
        _maxDepth = maxDepth;
        _maxDegreeOfParallelism = maxDegreeOfParallelism;
        
        _baseUri = new Uri(Url);
        _maxDepth = maxDepth;
        TryEnqueue(new CrawlTarget(Url, 0));
    }

    public void StopCrawling()
    {
        // Signal the ActionBlock to stop processing new messages
        _logger.LogInformation("Stopping the crawler...");
        _messageQueue?.Complete();

        // TODO: Optionally, you can cancel the token to stop processing immediately (but not for now)
        //_shouldCancel.Cancel();
    }

    public async Task WaitForCompletionAsync()
    {
        if (_messageQueue != null)
        {
            await _messageQueue.Completion;
        }
    }

    public bool IsCompleted => _messageQueue.Completion.IsCompleted;


    // Method to process incoming URLs for the ActionBlock
    private async Task ProcessUrl(CrawlTarget target)
    {
        int nextDepth = 0;
        try
        {
            using var processor = new PageProcessor(target.Url, _logger);
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

                bool enqued = TryEnqueue(new CrawlTarget(normalizedLink, nextDepth));

                if (enqued)
                {
                    _logger.LogInformation("Adding link {Link} at depth {Depth}, to the graph", normalizedLink, nextDepth);
                    var newVertex = new PSVertex(normalizedLink);
                    var newEdge = new PSEdge(graphSourceNode, newVertex, new PSEdgeTag("CrawlEdge"));

                    var addOpResult = _graph.AddVertex(newVertex);
                    _logger.LogInformation("Adding vertex {v}: {result}", newVertex, addOpResult);

                    addOpResult = _graph.AddEdge(newEdge);
                    _logger.LogInformation("Adding edge from {Source} to {Target}: {result}", graphSourceNode, newVertex, addOpResult);
                }
                else
                {
                    _logger.LogInformation("Skipping graph for link {Link} at depth {Depth}, already added", normalizedLink, nextDepth);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Processing URL: {Url} failed with: {exception}", target.Url, ex.Message);
            return;
        }
        finally
        {
            TryDequeueAndComplete(target);
        }

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

    private void TryDequeueAndComplete(CrawlTarget target)
    {
        var opResult = _planned.TryRemove(target.Url, out _);
        _logger.LogInformation("Removing URL {Url} from planned tasks, at depth {depth} as processed: {result}", target.Url, target.Depth, opResult);

        opResult = _visited.TryAdd(target.Url, target.Depth);
        _logger.LogInformation("Adding URL {Url} to visited tasks at depth {depth}: {result}", target.Url, target.Depth, opResult);

        int prev;
        do
        {
            prev = _maxReachedDepth;
            if (target.Depth <= prev)
                break;
        }
        while (Interlocked.CompareExchange(ref _maxReachedDepth, target.Depth, prev) != prev);

        lock (_dequeueLock)
        {
            _pendingCount--;

            if ((_pendingCount == 0 || _maxReachedDepth >= _maxDepth)
                && !_messageQueue.Completion.IsCompleted)
            {
                _messageQueue.Complete();
            }
        }

        int completed = _visited.Count;
        int total = _visited.Count + _planned.Count;
        ProgressChanged?.Invoke(completed, total);
    }

    private bool TryEnqueue(CrawlTarget target)
    {
        if (target.Depth > _maxDepth)
        {
            _logger.LogInformation("Reached maximum depth {depth} for URL, skipping: {Url}", target.Depth, target.Url);
            return false;
        }

        if (_visited.ContainsKey(target.Url))
        {
            _logger.LogInformation("URL already visited, skip adding a task for processing: {Url}", target.Url);
            return false;
        }

        if (!_planned.TryAdd(target.Url, target.Depth))
        {
            _logger.LogInformation("URL already planned, skipping processing: {Url}", target.Url);
            return false;
        }

        bool posted;
        lock (_dequeueLock)
        {
            posted = _messageQueue!.Post(target);
            if (posted)
            {
                _pendingCount++;
            }
        }

        if (!posted)
        {
            _planned.TryRemove(target.Url, out _);
            _logger.LogWarning("Failed to post target: {Url}, possibly completed or queue full", target.Url);
        }

        return posted;
    }

    public void Dispose()
    {
        _shouldCancel?.Dispose();
    }
}
