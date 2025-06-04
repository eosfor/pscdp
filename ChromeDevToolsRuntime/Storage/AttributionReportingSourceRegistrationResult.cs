namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingSourceRegistrationResult
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingSourceRegistrationResult
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "internalError")]
        InternalError,
        [EnumMember(Value = "insufficientSourceCapacity")]
        InsufficientSourceCapacity,
        [EnumMember(Value = "insufficientUniqueDestinationCapacity")]
        InsufficientUniqueDestinationCapacity,
        [EnumMember(Value = "excessiveReportingOrigins")]
        ExcessiveReportingOrigins,
        [EnumMember(Value = "prohibitedByBrowserPolicy")]
        ProhibitedByBrowserPolicy,
        [EnumMember(Value = "successNoised")]
        SuccessNoised,
        [EnumMember(Value = "destinationReportingLimitReached")]
        DestinationReportingLimitReached,
        [EnumMember(Value = "destinationGlobalLimitReached")]
        DestinationGlobalLimitReached,
        [EnumMember(Value = "destinationBothLimitsReached")]
        DestinationBothLimitsReached,
        [EnumMember(Value = "reportingOriginsPerSiteLimitReached")]
        ReportingOriginsPerSiteLimitReached,
        [EnumMember(Value = "exceedsMaxChannelCapacity")]
        ExceedsMaxChannelCapacity,
        [EnumMember(Value = "exceedsMaxScopesChannelCapacity")]
        ExceedsMaxScopesChannelCapacity,
        [EnumMember(Value = "exceedsMaxTriggerStateCardinality")]
        ExceedsMaxTriggerStateCardinality,
        [EnumMember(Value = "exceedsMaxEventStatesLimit")]
        ExceedsMaxEventStatesLimit,
        [EnumMember(Value = "destinationPerDayReportingLimitReached")]
        DestinationPerDayReportingLimitReached,
    }
}