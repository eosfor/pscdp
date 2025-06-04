namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingAggregatableResult
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingAggregatableResult
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "internalError")]
        InternalError,
        [EnumMember(Value = "noCapacityForAttributionDestination")]
        NoCapacityForAttributionDestination,
        [EnumMember(Value = "noMatchingSources")]
        NoMatchingSources,
        [EnumMember(Value = "excessiveAttributions")]
        ExcessiveAttributions,
        [EnumMember(Value = "excessiveReportingOrigins")]
        ExcessiveReportingOrigins,
        [EnumMember(Value = "noHistograms")]
        NoHistograms,
        [EnumMember(Value = "insufficientBudget")]
        InsufficientBudget,
        [EnumMember(Value = "insufficientNamedBudget")]
        InsufficientNamedBudget,
        [EnumMember(Value = "noMatchingSourceFilterData")]
        NoMatchingSourceFilterData,
        [EnumMember(Value = "notRegistered")]
        NotRegistered,
        [EnumMember(Value = "prohibitedByBrowserPolicy")]
        ProhibitedByBrowserPolicy,
        [EnumMember(Value = "deduplicated")]
        Deduplicated,
        [EnumMember(Value = "reportWindowPassed")]
        ReportWindowPassed,
        [EnumMember(Value = "excessiveReports")]
        ExcessiveReports,
    }
}