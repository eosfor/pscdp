using BaristaLabs.ChromeDevTools.Runtime.Target;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.WebSockets;
using System.Text;

public class BrowserController
{
    private const string DefaultWebsocketTargetUrl = "http://localhost:9222/json";
    public static async Task<List<DevToolsTarget>> GetWebsocketDebugTargets(string WebsocketTargetUrl = DefaultWebsocketTargetUrl)
    {
        var httpClient = new HttpClient();
        string listJson = await httpClient.GetStringAsync(WebsocketTargetUrl);
        var pages = JsonConvert.DeserializeObject<List<DevToolsTarget>>(listJson);

        return pages ?? new List<DevToolsTarget>();
    }

    public static async Task<DevToolsTarget> NewBrowserTab(string url = "about:blank")
    {
        var httpClient = new HttpClient();
        var tabUrl = $"{DefaultWebsocketTargetUrl}/new?{Uri.EscapeDataString(url)}";
        var response = await httpClient.PutAsync(tabUrl, null);
        if (response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync();
            var tabInfo = JsonConvert.DeserializeObject<DevToolsTarget>(responseBody);
            if (tabInfo == null || string.IsNullOrEmpty(tabInfo.Id) || string.IsNullOrEmpty(tabInfo.WebSocketDebuggerUrl))
            {
                throw new Exception("Failed to create new browser tab: Invalid response data.");
            }
            return tabInfo;
        }
        else
        {
            throw new Exception($"Failed to create new browser tab: {response.ReasonPhrase}");
        }
    }

    public static async Task<string> CloseBrowserTab(string targetId)
    {
        var httpClient = new HttpClient();
        var closeUrl = $"{DefaultWebsocketTargetUrl}/close/{targetId}";
        var response = await httpClient.GetAsync(closeUrl);
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode && content.Contains("Target is closing"))
        {
            return "Tab closed successfully.";
        }
        else
        {
            throw new Exception($"Failed to close browser tab: {response.ReasonPhrase}. Content: {content}");
        }
    }
}