namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Corresponds to mojom::SpeculationTargetHint.
    /// See https://github.com/WICG/nav-speculation/blob/main/triggers.md#window-name-targeting-hints
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpeculationTargetHint
    {
        [EnumMember(Value = "Blank")]
        Blank,
        [EnumMember(Value = "Self")]
        Self,
    }
}