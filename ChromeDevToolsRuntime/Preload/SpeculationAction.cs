namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type of preloading attempted. It corresponds to
    /// mojom::SpeculationAction (although PrefetchWithSubresources is omitted as it
    /// isn't being used by clients).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpeculationAction
    {
        [EnumMember(Value = "Prefetch")]
        Prefetch,
        [EnumMember(Value = "Prerender")]
        Prerender,
    }
}