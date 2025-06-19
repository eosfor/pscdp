namespace quickcrawl.core;

using System;
using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

public class ThreadSafeLogEntry
{
    public LogLevel Level;
    public string Message;
    public Exception? Exception;
}

public class PSLogger : ILogger
{
    private readonly ConcurrentQueue<ThreadSafeLogEntry> _logBuffer = new();

    public ConcurrentQueue<ThreadSafeLogEntry> LogBuffer => _logBuffer;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return default!;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        var message = formatter(state, exception);
        _logBuffer.Enqueue(new ThreadSafeLogEntry
        {
            Level = logLevel,
            Message = message,
            Exception = exception
        });
    }
}