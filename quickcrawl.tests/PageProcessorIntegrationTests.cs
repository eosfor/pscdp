namespace quickcrawl.tests;

using System;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;
using Microsoft.Extensions.Logging;

public class PageProcessorIntegrationTests : IDisposable
{
    private readonly ITestOutputHelper _output;
    private readonly ILogger<PageProcessor> _logger;

    public PageProcessorIntegrationTests(ITestOutputHelper output)
    {
        _output = output;
        _logger = LoggerFactory
            .Create(builder => builder.AddProvider(new XUnitLoggerProvider(_output)).SetMinimumLevel(LogLevel.Debug))
            .CreateLogger<PageProcessor>();
    }

    [Fact]
    public async Task Should_Open_Page_And_Trigger_Event_Handlers()
    {
        var testUrl = "https://azazello.darkcity.dev";
        var processor = new PageProcessor(testUrl, _logger);

        var links = await processor.ProcessPageAsync();
        processor.Dispose();
    }

    public void Dispose()
    {
        _output.WriteLine("Test finished.");
    }
}

