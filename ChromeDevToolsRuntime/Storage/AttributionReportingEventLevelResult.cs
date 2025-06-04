namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingEventLevelResult
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingEventLevelResult
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "successDroppedLowerPriority")]
        SuccessDroppedLowerPriority,
        [EnumMember(Value = "internalError")]
        InternalError,
        [EnumMember(Value = "noCapacityForAttributionDestination")]
        NoCapacityForAttributionDestination,
        [EnumMember(Value = "noMatchingSources")]
        NoMatchingSources,
        [EnumMember(Value = "deduplicated")]
        Deduplicated,
        [EnumMember(Value = "excessiveAttributions")]
        ExcessiveAttributions,
        [EnumMember(Value = "priorityTooLow")]
        PriorityTooLow,
        [EnumMember(Value = "neverAttributedSource")]
        NeverAttributedSource,
        [EnumMember(Value = "excessiveReportingOrigins")]
        ExcessiveReportingOrigins,
        [EnumMember(Value = "noMatchingSourceFilterData")]
        NoMatchingSourceFilterData,
        [EnumMember(Value = "prohibitedByBrowserPolicy")]
        ProhibitedByBrowserPolicy,
        [EnumMember(Value = "noMatchingConfigurations")]
        NoMatchingConfigurations,
        [EnumMember(Value = "excessiveReports")]
        ExcessiveReports,
        [EnumMember(Value = "falselyAttributedSource")]
        FalselyAttributedSource,
        [EnumMember(Value = "reportWindowPassed")]
        ReportWindowPassed,
        [EnumMember(Value = "notRegistered")]
        NotRegistered,
        [EnumMember(Value = "reportWindowNotStarted")]
        ReportWindowNotStarted,
        [EnumMember(Value = "noMatchingTriggerData")]
        NoMatchingTriggerData,
    }
}