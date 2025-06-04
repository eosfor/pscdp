namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingTriggerDataMatching
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingTriggerDataMatching
    {
        [EnumMember(Value = "exact")]
        Exact,
        [EnumMember(Value = "modulus")]
        Modulus,
    }
}