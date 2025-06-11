namespace pscdp;

using System;
using System.Management.Automation;
using System.Threading.Tasks;
using BaristaLabs.ChromeDevTools.Runtime;
using BaristaLabs.ChromeDevTools.Runtime.Page;
using BaristaLabs.ChromeDevTools.Runtime.Network;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks.Dataflow;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text;
using quickcrawl;

[Cmdlet(VerbsLifecycle.Start, "Crawling")]
public class StartCrawlingCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    public string? Url = "https://www.epam.com";

    [Parameter(Position = 1)]
    public int Depth = 5;

    [Parameter(Position = 2)]
    [ValidateNotNullOrEmpty]
    public string? ChromeDebuggerUrl;

    [Parameter(Position = 3)]
    public string? ExecutablePath = "/Users/andrei/repo/pscdp/quickcrawl/bin/Debug/net9.0/publish/quickcrawl";

    private Process? _crawlerProcess;

    protected override void BeginProcessing()
    {
        base.BeginProcessing();

        var path = ExecutablePath ?? Path.Combine(AppContext.BaseDirectory, "quickcrawl");
        if (!File.Exists(path))
        {
            ThrowTerminatingError(new ErrorRecord(
                new FileNotFoundException("quickcrawl executable not found", path),
                "CrawlerNotFound",
                ErrorCategory.ObjectNotFound,
                path
            ));
        }

        _crawlerProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = path,
                Arguments = ChromeDebuggerUrl != null ? $"\"{ChromeDebuggerUrl}\"" : ""
            }
        };

        // _crawlerProcess.OutputDataReceived += (_, e) =>
        // {
        //     if (e.Data != null)
        //         WriteVerbose($"[stdout] {e.Data}");
        // };

        // _crawlerProcess.ErrorDataReceived += (_, e) =>
        // {
        //     if (e.Data != null)
        //         WriteWarning($"[stderr] {e.Data}");
        // };

        _crawlerProcess.Start();
        // _crawlerProcess.BeginOutputReadLine();
        // _crawlerProcess.BeginErrorReadLine();

        WriteVerbose($"Started quickcrawl PID {_crawlerProcess.Id}");
    }

    protected override void ProcessRecord()
    {
        if (Url == null)
            return;

        WriteVerbose("Sending crawl command over pipe...");

        using var pipe = new NamedPipeClientStream(".", "QuickCrawlCommandPipe", PipeDirection.Out);
        pipe.Connect(5000); // timeout in ms

        var command = new CrawlCommand
        {
            Url = Url,
            Depth = Depth
            //ChromeDebugUrl = ChromeDebuggerUrl
        };

        var json = JsonConvert.SerializeObject(command);
        using var writer = new StreamWriter(pipe, Encoding.UTF8) { AutoFlush = true };
        writer.Write(json);

        WriteVerbose("Crawl command sent.");
    }

    protected override void EndProcessing()
    {
        base.EndProcessing();

        if (_crawlerProcess != null && !_crawlerProcess.HasExited)
        {
            _crawlerProcess.Kill(true);
            _crawlerProcess.Dispose();
            WriteVerbose("quickcrawl process terminated.");
        }
    }
}