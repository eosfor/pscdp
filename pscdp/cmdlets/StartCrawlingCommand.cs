namespace pscdp;

using System;
using System.Management.Automation;
using System.Threading.Tasks;
using BaristaLabs.ChromeDevTools.Runtime;
using BaristaLabs.ChromeDevTools.Runtime.Page;
using BaristaLabs.ChromeDevTools.Runtime.Network;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks.Dataflow;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? Url;

    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? ChromeDubugSessionUrl;


    private ActionBlock<string>? _messageQueue;
    private ChromeSession? _session;
    private CancellationTokenSource _shouldCancel = new CancellationTokenSource();

    private readonly BlockingCollection<IEvent> _capturedEvents = new BlockingCollection<IEvent>();

    private int _activeCount = 0;
    private readonly ConcurrentDictionary<string, byte> _visited = new(StringComparer.OrdinalIgnoreCase);

    protected override void ProcessRecord()
    {
        Interlocked.Increment(ref _activeCount);

        if (_messageQueue != null)
        {
            _messageQueue.Post(Url);
            _messageQueue.Completion.GetAwaiter().GetResult();
        }
        _shouldCancel.Cancel();

        WriteObject(_capturedEvents, true);
        _session.Dispose();
    }

    protected override void BeginProcessing()
    {

        base.BeginProcessing();

        _session = new ChromeSession(ChromeDubugSessionUrl);
        _session.Network.Enable(new BaristaLabs.ChromeDevTools.Runtime.Network.EnableCommand()).GetAwaiter().GetResult();
        _session.Page.Enable(new BaristaLabs.ChromeDevTools.Runtime.Page.EnableCommand(), cancellationToken: _shouldCancel.Token).GetAwaiter().GetResult();

        _messageQueue = new ActionBlock<string>(ProcessIncomingUrl, new ExecutionDataflowBlockOptions
        {
            MaxDegreeOfParallelism = 1,
            BoundedCapacity = 1000
        });

        _session.Page.SubscribeToFrameNavigatedEvent((e) =>
        {
            _capturedEvents.TryAdd(e);
        });

        _session.Network.SubscribeToRequestWillBeSentEvent((e) =>
        {
            _capturedEvents.TryAdd(e);
        });
    }

    private void ProcessIncomingUrl(string url)
    {
        try
        {
            var loadTcs = new TaskCompletionSource<bool>();

            _session.Page.SubscribeToLoadEventFiredEvent( (e) =>
            {
                loadTcs.TrySetResult(true);
            });

            _session.Page.Navigate(new NavigateCommand
            {
                Url = url
            }, millisecondsTimeout: 60000, cancellationToken: _shouldCancel.Token).GetAwaiter().GetResult();

            _visited.TryAdd(url, 0);

            // Ждём загрузки страницы
            loadTcs.Task.GetAwaiter().GetResult();

            var evalResult = _session.Runtime.Evaluate(new BaristaLabs.ChromeDevTools.Runtime.Runtime.EvaluateCommand
            {
                Expression = @"Array.from(document.querySelectorAll('a')).map(a => a.href).filter(h => h.startsWith(location.origin))",
                ReturnByValue = true
            }).GetAwaiter().GetResult();

            var urls = ((JArray)evalResult.Result.Value).ToObject<List<string>>();

            if (urls == null || urls.Count == 0)
            {
                return;
            }

            foreach (var link in urls)
            {
                if (_visited.TryAdd(link, 0))
                {
                    Interlocked.Increment(ref _activeCount);
                    _messageQueue.Post(link);
                }
            }
        }
        finally
        {
            var remaining = Interlocked.Decrement(ref _activeCount);
            if (remaining == 0)
            {
                _messageQueue.Complete();
            }
        }
    }
}