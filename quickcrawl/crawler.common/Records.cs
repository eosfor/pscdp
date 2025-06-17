using System.Collections.Concurrent;
using BaristaLabs.ChromeDevTools.Runtime;
using PSGraph.Model;

namespace quickcrawl;

public record CrawlTarget(string Url, int Depth);

public record ProcessedUrlData(string url, List<IEvent> events);

public record Result(PsBidirectionalGraph Graph, List<ProcessedUrlData> CapturedEvents);