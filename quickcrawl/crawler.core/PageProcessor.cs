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
    private DevToolsTarget? _browserTabTarget;
    private ILogger _logger;

    private CancellationTokenSource _shouldCancel = new CancellationTokenSource();

    private ConcurrentDictionary<long, Node> _nodeDictionary = new ConcurrentDictionary<long, Node>();

    private TaskCompletionSource<bool>? _pageLoadEventFlag;

    private ConcurrentBag<IEvent> _capturedEvents = new ConcurrentBag<IEvent>();

    public List<IEvent> CapturedEvents => _capturedEvents.ToList();

    public PageProcessor(string url)
    {
        _url = url;
        _logger = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Debug)).CreateLogger<PageProcessor>();
    }

    public PageProcessor(string url, ILogger logger)
    {
        _url = url;
        _logger = logger;
    }


    private async Task OpenChromeSessionAsync()
    {
        _logger.LogDebug("Opening new Chrome session for URL: {Url}", _url);
        _browserTabTarget = await BrowserController.NewBrowserTab();
        if (_browserTabTarget == null || string.IsNullOrEmpty(_browserTabTarget.Id) || string.IsNullOrEmpty(_browserTabTarget.WebSocketDebuggerUrl))
        {
            throw new Exception("Failed to create new browser tab.");
        }

        _logger.LogDebug("New Chrome session opened with ID: {Id} and WebSocket URL: {WebSocketDebuggerUrl}", _browserTabTarget.Id, _browserTabTarget.WebSocketDebuggerUrl);
        _session = new ChromeSession(_browserTabTarget.WebSocketDebuggerUrl);

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

        await WaitForPageLoadAsync(TimeSpan.FromSeconds(30));

        var links = await ExtractLinksFromPage();
        return links;
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
            Node node;
            try
            {
                node = _nodeDictionary[nodeId];
            }
            catch (KeyNotFoundException)
            {
                _logger.LogWarning("Node with ID {NodeId} not found in the node dictionary.", nodeId);
                continue;
            }


            _logger.LogDebug("Processing node with ID: {NodeId}", nodeId);

            var href = node.Attributes?
                .SkipWhile(attr => attr != "href")
                .Skip(1)
                .FirstOrDefault();

            if (!string.IsNullOrEmpty(href))
            {
                var baseUri = new Uri(_url);
                var fullUri = new Uri(baseUri, href);
                var link = fullUri.GetLeftPart(UriPartial.Path);

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

    private async Task WaitForNetworkIdleAsync(int timeoutMs = 2000, int maxRequestAgeMs = 6000, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException("Network idle detection is not implemented yet.");
    }

    private async Task WaitForPageLoadAsync(TimeSpan timeout)
    {
        if (_pageLoadEventFlag == null)
            throw new InvalidOperationException("Loading was not started.");

        using var cts = new CancellationTokenSource(timeout);
        await Task.WhenAny(_pageLoadEventFlag.Task, Task.Delay(Timeout.Infinite, cts.Token));

        if (!_pageLoadEventFlag.Task.IsCompleted)
            throw new TimeoutException("Page load timed out.");

        await _pageLoadEventFlag.Task; // throws if faulted or canceled
    }

    private void OnSetChildNodesEvent(SetChildNodesEvent e)
    {
        //_capturedEvents.Add(e);
        foreach (var node in e.Nodes)
        {
            _nodeDictionary.AddOrUpdate(node.NodeId, node, (id, previousNode) => node);
        }
    }

    private void OnDocumentUpdated(DocumentUpdatedEvent e)
    {
        //_capturedEvents.Add(e);
        _nodeDictionary.Clear();
        _nodeDictionary.Clear();
    }

    private void OnRequestFinished(LoadingFinishedEvent e)
    {
        //_capturedEvents.Add(e);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Request finished:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnRequestStarted(RequestWillBeSentEvent e)
    {
        _capturedEvents.Add(e);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Request started:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnFrameStoppedLoadingAsync(FrameStoppedLoadingEvent e)
    {
        //_capturedEvents.Add(e);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame stopped loading:\n{Json}", json);
        _pageLoadEventFlag?.TrySetResult(true);
        //throw new NotImplementedException();
    }

    private void OnFrameStartedLoadingAsync(FrameStartedLoadingEvent e)
    {
        //_capturedEvents.Add(e);
        _pageLoadEventFlag = new(TaskCreationOptions.RunContinuationsAsynchronously);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame started loading:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnLoadEventFiredEventAsync(LoadEventFiredEvent e)
    {
        //_capturedEvents.Add(e);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Load event fired:\n{Json}", json);
        //throw new NotImplementedException();
    }

    private void OnFrameNavigatedAsync(FrameNavigatedEvent e)
    {
        //_capturedEvents.Add(e);
        string json = JsonConvert.SerializeObject(e, Formatting.Indented);
        _logger.LogDebug("Frame navigated:\n{Json}", json);
        //throw new NotImplementedException();
    }

    public void Dispose()
    {
        if (_browserTabTarget?.Id != null)
        {
            BrowserController.CloseBrowserTab(_browserTabTarget.Id).GetAwaiter().GetResult();
        }
        _shouldCancel.Cancel();
        _capturedEvents.Clear();
        _nodeDictionary.Clear();
        _session?.Dispose();
    }
}