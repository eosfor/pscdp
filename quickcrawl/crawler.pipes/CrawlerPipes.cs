namespace quickcrawl.server;

using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;
using quickcrawl.core;
using quickcrawl;
using BaristaLabs.ChromeDevTools.Runtime;
using Newtonsoft.Json;

public class CrawlerPipes
{
    private const string CommandPipeName = "QuickCrawlCommandPipe";
    private const string EventPipeName = "QuickCrawlEventPipe";
    private readonly QuickCrawler _crawler;


    public CrawlerPipes()
    {
        _crawler = new QuickCrawler();
    }

    public async Task RunAsync()
    {
        // Параллельно принимаем команды и отсылаем события
        var commandTask = HandleCommandPipe();
        var eventTask = HandleEventPipe();

        await Task.WhenAll(commandTask, eventTask);
    }

    private async Task HandleCommandPipe()
    {
        while (true)
        {
            using var pipe = new NamedPipeServerStream(CommandPipeName, PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
            await pipe.WaitForConnectionAsync();

            using var reader = new StreamReader(pipe, Encoding.UTF8);
            var commandJson = await reader.ReadToEndAsync();

            var command = JsonConvert.DeserializeObject<CrawlCommand>(commandJson);
            if (command is { Url: not null, Depth: > 0 })
            {
                _crawler.StartCrawling(command.Url, command.Depth);
            }
        }
    }
    private async Task HandleEventPipe()
    {
        while (true)
        {
            using var pipe = new NamedPipeServerStream(EventPipeName, PipeDirection.Out, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
            await pipe.WaitForConnectionAsync();

            using var writer = new StreamWriter(pipe, Encoding.UTF8) { AutoFlush = true };

            void Handler(IEvent ev)
            {
                var json = JsonConvert.SerializeObject(ev, ev.GetType(), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

                try
                {
                    writer.WriteLine(json); // sync — потому что мы не можем await из sync handler
                }
                catch (IOException)
                {
                    // клиент отключился
                    _crawler.OnEventCaptured -= Handler;
                }
            }

            _crawler.OnEventCaptured += Handler;

            // ждём, пока пайп отключится
            while (pipe.IsConnected)
            {
                await Task.Delay(100); // простое ожидание
            }

            _crawler.OnEventCaptured -= Handler;
        }
    }
}