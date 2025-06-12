using System.Collections.Concurrent;
using BaristaLabs.ChromeDevTools.Runtime;

namespace quickcrawl;

public record CrawlTarget(string Url, int Depth);

public record ProcessedUrlData(string url, List<IEvent> events);