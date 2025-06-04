namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingSourceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingSourceType
    {
        [EnumMember(Value = "navigation")]
        Navigation,
        [EnumMember(Value = "event")]
        Event,
    }
}