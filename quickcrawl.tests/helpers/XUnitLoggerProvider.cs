namespace quickcrawl.tests;

using Microsoft.Extensions.Logging;
using Xunit.Abstractions;
using Xunit;

public class XUnitLoggerProvider : ILoggerProvider
{
    private readonly ITestOutputHelper _output;

    public XUnitLoggerProvider(ITestOutputHelper output)
    {
        _output = output;
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new XUnitLogger(_output);
    }

    public void Dispose() { }
}

public class XUnitLogger : ILogger
{
    private readonly ITestOutputHelper _output;

    public XUnitLogger(ITestOutputHelper output)
    {
        _output = output;
    }

    public IDisposable BeginScope<TState>(TState state) => default!;
    public bool IsEnabled(LogLevel logLevel) => true;

    public void Log<TState>(
        LogLevel logLevel, 
        EventId eventId,
        TState state,
        Exception exception,
        Func<TState, Exception?, string> formatter)
    {
        _output.WriteLine($"{logLevel}: {formatter(state, exception)}");
    }
}