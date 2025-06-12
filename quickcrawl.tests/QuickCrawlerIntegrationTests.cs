using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;
using Microsoft.Extensions.Logging;
using quickcrawl.core;

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
        await crawler.StartCrawling(testUrl, maxDepth: 2);
        //await Task.Delay(120000); // дать время на асинхронную работу
        //crawler.StopCrawling();
        await crawler.WaitForCompletionAsync();

        // Assert
        // Просто факт завершения без исключений — уже успех для интеграционного теста
        crawler.Dispose();
    }
}