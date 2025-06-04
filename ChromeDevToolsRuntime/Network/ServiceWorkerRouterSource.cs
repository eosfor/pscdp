namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Source of service worker router.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceWorkerRouterSource
    {
        [EnumMember(Value = "network")]
        Network,
        [EnumMember(Value = "cache")]
        Cache,
        [EnumMember(Value = "fetch-event")]
        FetchEvent,
        [EnumMember(Value = "race-network-and-fetch-handler")]
        RaceNetworkAndFetchHandler,
        [EnumMember(Value = "race-network-and-cache")]
        RaceNetworkAndCache,
    }
}