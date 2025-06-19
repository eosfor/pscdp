namespace pscdp;

using System.Management.Automation;
using System.Diagnostics;
using quickcrawl.core; // Assuming you have a CrawlerCore class in your project
using quickcrawl;
using Microsoft.Extensions.Logging;

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? Url;

    [Parameter(Mandatory =false, Position = 1)]
    public int Depth = 0;

    [Parameter(Mandatory = false, Position = 2)]
    public int MaxDegreeOfParallelism = 4;

    private QuickCrawler _crawler;
    private PSLogger _logger = new PSLogger();

    private int _completed = 0;
    private int _total = 1;
    private readonly object _progressLock = new();

    protected override void BeginProcessing()
    {
        base.BeginProcessing();
        _crawler = new QuickCrawler(_logger);
        _crawler.ProgressChanged += OnProgressChanged;
    }


    protected override void ProcessRecord()
    {
        _crawler.StartCrawling(Url, maxDepth: Depth, maxDegreeOfParallelism: MaxDegreeOfParallelism);

        // we have to do this as powershell is syncronous and WriteProgess and otjer Write... can only be called from this method
        while (!_crawler.IsCompleted)
        {
            Thread.Sleep(200);

            int completed, total;
            lock (_progressLock)
            {
                completed = _completed;
                total = _total;
            }

            int percent = total == 0 ? 0 : (int)((double)completed / total * 100);
            WriteProgress(new ProgressRecord(1, "Crawling website", $"{completed}/{total} processed")
            {
                PercentComplete = percent
            });
        }

        WriteObject(new Result(_crawler.Graph, _crawler.CapturedEvents), false);
    }

    protected override void EndProcessing()
    {
        base.EndProcessing();
        WriteProgress(new ProgressRecord(1, "Crawling website", "Done")
        {
            RecordType = ProgressRecordType.Completed
        });
        FlushLogs();
    }

    protected override void StopProcessing()
    {
        base.StopProcessing();
        _crawler?.StopCrawling();
    }

    private void FlushLogs()
    {
        while (_logger.LogBuffer.TryDequeue(out var entry))
        {
            switch (entry.Level)
            {
                case LogLevel.Debug:
                    if (MyInvocation.BoundParameters.ContainsKey("Debug"))
                        WriteDebug(entry.Message);
                    break;

                case LogLevel.Information:
                    if (MyInvocation.BoundParameters.ContainsKey("Verbose"))
                        WriteVerbose(entry.Message);
                    break;

                case LogLevel.Warning:
                    if (MyInvocation.BoundParameters.ContainsKey("Verbose"))
                        WriteWarning(entry.Message);
                    break;

                case LogLevel.Error:
                    if (MyInvocation.BoundParameters.ContainsKey("Debug"))
                        WriteError(new ErrorRecord(entry.Exception ?? new Exception(entry.Message), "Error", ErrorCategory.NotSpecified, null));
                    break;
            }
        }
    }

    private void OnProgressChanged(int completed, int total)
    {
        lock (_progressLock)
        {
            _completed = completed;
            _total = total;
        }
    }
}