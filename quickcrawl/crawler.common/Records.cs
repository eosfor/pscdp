using System.Collections.Concurrent;
using BaristaLabs.ChromeDevTools.Runtime;
using PSGraph.Model;

namespace quickcrawl;

public record CrawlTarget(string Url, int Depth);

public record ProcessedUrlData(CrawlTarget page, List<IEvent> events, List<string> links);

public record Result(PsBidirectionalGraph Graph, List<ProcessedUrlData> CapturedEvents);