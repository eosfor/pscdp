namespace pscdp;

using System.Management.Automation;
using System.Diagnostics;
using quickcrawl.core; // Assuming you have a CrawlerCore class in your project

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    public string? Url = "https://www.epam.com";

    [Parameter(Position = 1)]
    public int Depth = 5;

    protected override void BeginProcessing()
    {
        base.BeginProcessing();


    }

    protected override void ProcessRecord()
    {
        var crawler = new QuickCrawler();
        var testUrl = "https://azazello.darkcity.dev";

        // Act
        crawler.StartCrawling(testUrl, maxDepth: 2).GetAwaiter().GetResult();
        //await Task.Delay(120000); // дать время на асинхронную работу
        //crawler.StopCrawling();
        crawler.WaitForCompletionAsync().GetAwaiter().GetResult();

        WriteObject(crawler.CapturedEvents, true);

        // Assert
        // Просто факт завершения без исключений — уже успех для интеграционного теста
        crawler.Dispose();
    }

    protected override void EndProcessing()
    {
        base.EndProcessing();
    }
}