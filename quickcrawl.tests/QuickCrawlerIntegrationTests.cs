using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;
using Microsoft.Extensions.Logging;
using quickcrawl.core;
using System.Diagnostics.Tracing;
using Newtonsoft.Json.Linq;
using PSGraph.Model;

namespace quickcrawl.tests;

public class QuickCrawlerIntegrationTests
{
    private readonly ITestOutputHelper _output;
    private readonly ILogger<QuickCrawler> _logger;

    public QuickCrawlerIntegrationTests(ITestOutputHelper output)
    {
        _output = output;
        _logger = LoggerFactory
            .Create(builder => builder.AddProvider(new XUnitLoggerProvider(output)).SetMinimumLevel(LogLevel.Debug))
            .CreateLogger<QuickCrawler>();
    }

    [Fact]
    public async Task Should_Crawl_Page_And_Follow_Links()
    {
        // Arrange
        var crawler = new QuickCrawler(_logger);
        var testUrl = "https://azazello.darkcity.dev";

        // Act
        crawler.StartCrawling(testUrl, maxDepth: 1);
        //await Task.Delay(120000); // дать время на асинхронную работу
        //crawler.StopCrawling();
        await crawler.WaitForCompletionAsync();
        var events = crawler.CapturedEvents;
        var graph = crawler.Graph;

        // Assert
        events.Should().NotBeNull();
        events.Should().NotBeEmpty();
        graph.Should().NotBeNull();
        graph.Vertices.Should().NotBeEmpty();
        graph.Edges.Should().NotBeEmpty();
        crawler.Dispose();
    }
}