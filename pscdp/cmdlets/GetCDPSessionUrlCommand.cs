namespace pscdp;

using System;
using System.Management.Automation;
using System.Text.Json.Nodes;

[Cmdlet(VerbsCommon.Get, "CDPSessionUrl")]
public class GetCDPSessionUrlCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    [ValidateNotNullOrEmpty]
    public string? ChromeSessionUrl = "http://localhost:9222/json";

    protected override void ProcessRecord()
    {
        var httpClient = new HttpClient();
        string listJson = httpClient.GetStringAsync("http://localhost:9222/json").GetAwaiter().GetResult();
        var pages = JsonNode.Parse(listJson)?.AsArray();

        if (pages == null || pages.Count == 0)
        {
            var errorRecord = new ErrorRecord(
                new Exception("Did not find any CDP pages, please check if Chromium/Chrome is running with --remote-debugging-port=9222."),
                "NoCDPPagesFound",
                ErrorCategory.ObjectNotFound,
                null
            );
            WriteError(errorRecord);
            return;
        }

        WriteObject(pages, true);
    }
}