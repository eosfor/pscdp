using System.Collections.Concurrent;
using BaristaLabs.ChromeDevTools.Runtime;
using BaristaLabs.ChromeDevTools.Runtime.DOM;
using BaristaLabs.ChromeDevTools.Runtime.Network;
using BaristaLabs.ChromeDevTools.Runtime.Page;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

public class PageProcessor : IDisposable
{

    private string _url { get; set; }
    private ChromeSession? _session;
    private DevToolsTarget? _target;
    private ILogger<PageProcessor> _logger; // Assuming you have a logger injected or set up elsewhere

    private CancellationTokenSource _shouldCancel = new CancellationTokenSource();

    private ConcurrentDictionary<long, Node> _nodeDictionary = new ConcurrentDictionary<long, Node>();

    private readonly ConcurrentDictionary<string, TrackedRequest> _activeRequests = new();
    private DateTime _lastNetworkActivity;
    private const int NetworkIdleTimeoutMs = 2000;
    private const int MaxInflightRequests = 0;

    public PageProcessor(string url)
    {
        _url = url;
        _logger = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Debug)).CreateLogger<PageProcessor>();
    }

    public PageProcessor(string url, ILogger<PageProcessor> logger)
    {
        _url = url;
        _logger = logger;
    }


    private async Task OpenChromeSessionAsync()
    {
        _logger.LogDebug("Opening new Chrome session for URL: {Url}", _url);
        _target = await BrowserController.NewBrowserTab();
        if (_target == null || string.IsNullOrEmpty(_target.Id) || string.IsNullOrEmpty(_target.WebSocketDebuggerUrl))
        {
            throw new Exception("Failed to create new browser tab.");
        }

        _logger.LogDebug("New Chrome session opened with ID: {Id} and WebSocket URL: {WebSocketDebuggerUrl}", _target.Id, _target.WebSocketDebuggerUrl);
        _session = new ChromeSession(_target.WebSocketDebuggerUrl);

        await _session.Network.Enable(new BaristaLabs.ChromeDevTools.Runtime.Network.EnableCommand(), cancellationToken: _shouldCancel.Token);
        await _session.Page.Enable(new BaristaLabs.ChromeDevTools.Runtime.Page.EnableCommand(), cancellationToken: _shouldCancel.Token);
        await _session.DOM.Enable(new BaristaLabs.ChromeDevTools.Runtime.DOM.EnableCommand(), cancellationToken: _shouldCancel.Token);

        _session.Page.SubscribeToFrameNavigatedEvent(OnFrameNavigatedAsync);
        _session.Page.SubscribeToLoadEventFiredEvent(OnLoadEventFiredEventAsync);
        _session.Page.SubscribeToFrameStartedLoadingEvent(OnFrameStartedLoadingAsync);
        _session.Page.SubscribeToFrameStoppedLoadingEvent(OnFrameStoppedLoadingAsync);
        _session.Network.SubscribeToRequestWillBeSentEvent(OnRequestStarted);
        _session.Network.SubscribeToLoadingFinishedEvent(OnRequestFinished);
        _session.DOM.SubscribeToDocumentUpdatedEvent(OnDocumentUpdated);
        _session.DOM.SubscribeToSetChildNodesEvent(OnSetChildNodesEvent);
    }

    public async Task<List<string>> ProcessPageAsync()
    {
        if (_session == null)
        {
            await OpenChromeSessionAsync();
        }

        await _session.Page.Navigate(new NavigateCommand
        {
            Url = _url
        }, millisecondsTimeout: 60000, cancellationToken: _shouldCancel.Token);

        //TODO: Add logic to wait for the page to load completely, if necessary.
        await Task.Delay(6000);

        var links = await ExtractLinksFromPage();
        return links;

    }

    private void OnSetChildNodesEvent(SetChildNodesEvent e)
    {
        foreach (var node in e.Nodes)
        {
            _nodeDictionary.AddOrUpdate(node.NodeId, node, (id, previousNode) => node);
        }
    }

    private void OnDocumentUpdated(DocumentUpdatedEvent e)
    {
        _nodeDictionary.Clear();
        _nodeDictionary.Clear();
    }

    private async Task<List<string>> ExtractLinksFromPage()
    {
        _logger.LogDebug("Extracting links from the page...");
        var links = new List<string>();

        var dom = _session!.DOM;
        var doc = await dom.GetDocument(new GetDocumentCommand
        {
            Depth = 1
        });

        var anchorNodes = await dom.QuerySelectorAll(new QuerySelectorAllCommand
        {
            NodeId = doc.Root.NodeId,
            Selector = "a"
        });

        foreach (var nodeId in anchorNodes.NodeIds)
        {
            var node = _nodeDictionary[nodeId];
            var link = node.Attributes?.SkipWhile(attr => attr != "href")
                .Skip(1) // Skip the "href" attribute itself
                .FirstOrDefault(attr => attr.StartsWith("http", StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(link))
            {
                links.Add(link);
                _logger.LogDebug("Found link: {Link}", link);
            }
            else
            {
                _logger.LogDebug("No valid link found in node with ID: {NodeId}", nodeId);
            }
        }
        return links;
    }

    private async Task WaitForNetworkIdleAsync(int timeoutMs = NetworkIdleTimeoutMs, int maxRequestAgeMs = 6000, CancellationToken cancellationToken = default)
    {
        _logger.LogDebug("Waiting for network to become idle...");
        var idleSince = DateTime.UtcNow;

        while (true)
        {
            if (cancellationToken.IsCancellationRequested)
                break;

            var now = DateTime.UtcNow;

            // cleanup stuck requests
            foreach (var kvp in _activeRequests)
            {
                var age = (now - kvp.Value.Started).TotalMilliseconds;
                if (age > maxRequestAgeMs)
                {
                    _activeRequests.TryRemove(kvp.Key, out _);
                    _logger.LogWarning("Request {RequestId} has been active for too long ({Age} ms), removing it from active requests.", kvp.Key, age);
                }
            }

            var inflight = _activeRequests.Count;

            if (inflight <= MaxInflightRequests &&
                (now - _lastNetworkActivity).TotalMilliseconds >= timeoutMs)
            {
                return;
            }

            await Task.Delay(100, cancellationToken);
        }
    }


    private void OnRequestFinished(LoadingFinishedEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Request finished:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnRequestStarted(RequestWillBeSentEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Request started:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnFrameStoppedLoadingAsync(FrameStoppedLoadingEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame stopped loading:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnFrameStartedLoadingAsync(FrameStartedLoadingEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame started loading:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnLoadEventFiredEventAsync(LoadEventFiredEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Load event fired:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnFrameNavigatedAsync(FrameNavigatedEvent e)
    {
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame navigated:\n{Json}", json);
        //throw new NotImplementedException();
    }

    public void Dispose()
    {
        if (_target?.Id != null)
        {
            BrowserController.CloseBrowserTab(_target.Id).GetAwaiter().GetResult();
        }
        _shouldCancel.Cancel();
        _session?.Dispose();
    }
}