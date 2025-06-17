namespace pscdp;

using System;
using System.Management.Automation;
using Newtonsoft.Json;

[Cmdlet(VerbsCommon.Get, "CDPSessionUrl")]
public class GetCDPSessionUrlCommand : PSCmdlet
{
    [Parameter(Mandatory = false, Position = 0)]
    public string? ChromeSessionUrl = "http://localhost:9222/json";

    protected override void ProcessRecord()
    {
        var httpClient = new HttpClient();
        string listJson = httpClient.GetStringAsync(ChromeSessionUrl).GetAwaiter().GetResult();
        var pages = JsonConvert.DeserializeObject<List<DevToolsTarget>>(listJson);

        WriteObject(pages, true);
    }
}