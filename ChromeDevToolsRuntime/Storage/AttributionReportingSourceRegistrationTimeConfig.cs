namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingSourceRegistrationTimeConfig
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingSourceRegistrationTimeConfig
    {
        [EnumMember(Value = "include")]
        Include,
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}