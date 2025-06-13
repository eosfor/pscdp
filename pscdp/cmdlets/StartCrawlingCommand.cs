namespace pscdp;

using System.Management.Automation;
using System.Diagnostics;
using quickcrawl.core; // Assuming you have a CrawlerCore class in your project

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? Url;

    [Parameter(Position = 1)]
    public int Depth = 5;

    protected override void BeginProcessing()
    {
        base.BeginProcessing();


    }

    private QuickCrawler _crawler;

    protected override void ProcessRecord()
    {
        var _crawler = new QuickCrawler();

        // Act
        _crawler.StartCrawling(Url, maxDepth: Depth);
        _crawler.WaitForCompletionAsync().GetAwaiter().GetResult();

        WriteObject(_crawler.Graph, false);

        //_crawler.Dispose();
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