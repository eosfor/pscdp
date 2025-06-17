namespace pscdp;

using System.Management.Automation;
using System.Diagnostics;
using quickcrawl.core; // Assuming you have a CrawlerCore class in your project
using quickcrawl;

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? Url;

    [Parameter(Position = 1)]
    public int Depth = 0;

    private QuickCrawler _crawler;

    protected override void BeginProcessing()
    {
        base.BeginProcessing();
        _crawler = new QuickCrawler();
    }


    protected override void ProcessRecord()
    {
        _crawler.StartCrawling(Url, maxDepth: Depth);
        _crawler.WaitForCompletionAsync().GetAwaiter().GetResult();

        WriteObject(new Result(_crawler.Graph, _crawler.CapturedEvents), false);
    }

    protected override void EndProcessing()
    {
        base.EndProcessing();
    }

    protected override void StopProcessing()
    {
        base.StopProcessing();
        // Handle any cleanup if necessary
        _crawler?.StopCrawling();
    }
}