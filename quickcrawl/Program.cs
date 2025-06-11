using quickcrawl.server;
using quickcrawl.core;
using Newtonsoft.Json;

if (args.Length == 0 || string.IsNullOrWhiteSpace(args[0]))
{
    Console.Error.WriteLine("❌ Не указан параметр chromeDebugUrl.");
    Console.Error.WriteLine("Пример: dotnet quickcrawl.dll ws://localhost:9222/devtools/page/XXXX");
    Environment.Exit(1);
}

string chromeDebugUrl = args[0];

//var server = new CrawlerPipes(chromeDebugUrl);
var debugSessions = await BrowserController.GetWebsocketDebugTargets(chromeDebugUrl);
var crawler = new QuickCrawler();
await crawler.StartCrawling("https://www.epam.com", 5);
await crawler.WaitForCompletionAsync();
//Console.WriteLine($"🚀 QuickCrawl сервер подключается к {chromeDebugUrl} и ждёт команды...");
