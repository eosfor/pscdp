namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingReportResult
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingReportResult
    {
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "prohibited")]
        Prohibited,
        [EnumMember(Value = "failedToAssemble")]
        FailedToAssemble,
        [EnumMember(Value = "expired")]
        Expired,
    }
}