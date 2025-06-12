namespace quickcrawl.core;

using System;
using System.Threading.Tasks;
using BaristaLabs.ChromeDevTools.Runtime;
using BaristaLabs.ChromeDevTools.Runtime.Page;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks.Dataflow;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Xunit;

public class QuickCrawler
{
    private ActionBlock<CrawlTarget>? _messageQueue;
    private CancellationTokenSource _shouldCancel = new CancellationTokenSource();
    private readonly ConcurrentDictionary<string, int> _visited = new(StringComparer.OrdinalIgnoreCase);
    private ConcurrentBag<ProcessedUrlData> _capturedEvents = new ConcurrentBag<ProcessedUrlData>();
    private ILogger<QuickCrawler> _logger;

    public List<ProcessedUrlData> CapturedEvents => _capturedEvents.ToList();

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


    public async Task StartCrawling(string Url, int maxDepth = 10)
    {
        _maxDepth = maxDepth;
        _messageQueue?.Post(new CrawlTarget(Url, 0));
        await Task.CompletedTask;
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
            _messageQueue?.Complete();
            return;
        }
        _logger.LogInformation("Processing URL: {Url} at depth {Depth}", target.Url, target.Depth);
        if (_visited.ContainsKey(target.Url))
        {
            _logger.LogInformation("URL already visited: {Url}", target.Url);
            return;
        }
        try
        {
            using var processor = new PageProcessor(target.Url);
            var links = await processor.ProcessPageAsync();
            var events = processor.CapturedEvents;

            var processedData = new ProcessedUrlData(target.Url, events);
            _capturedEvents.Add(processedData);

            foreach (var link in links)
            {
                _messageQueue?.Post(new CrawlTarget(link, target.Depth + 1));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing URL: {Url}", target.Url);
            return;
        }
        finally
        {
            _visited.TryAdd(target.Url, target.Depth);
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

    public void Dispose()
    {
        _shouldCancel?.Dispose();
    }
}
