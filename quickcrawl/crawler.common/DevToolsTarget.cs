using Newtonsoft.Json;

public class DevToolsTarget
{
    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("devtoolsFrontendUrl")]
    public string DevtoolsFrontendUrl { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("parentId")]
    public string ParentId { get; set; } // может быть null

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("webSocketDebuggerUrl")]
    public string WebSocketDebuggerUrl { get; set; }
}