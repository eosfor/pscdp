namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// AttributionReportingIssueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributionReportingIssueType
    {
        [EnumMember(Value = "PermissionPolicyDisabled")]
        PermissionPolicyDisabled,
        [EnumMember(Value = "UntrustworthyReportingOrigin")]
        UntrustworthyReportingOrigin,
        [EnumMember(Value = "InsecureContext")]
        InsecureContext,
        [EnumMember(Value = "InvalidHeader")]
        InvalidHeader,
        [EnumMember(Value = "InvalidRegisterTriggerHeader")]
        InvalidRegisterTriggerHeader,
        [EnumMember(Value = "SourceAndTriggerHeaders")]
        SourceAndTriggerHeaders,
        [EnumMember(Value = "SourceIgnored")]
        SourceIgnored,
        [EnumMember(Value = "TriggerIgnored")]
        TriggerIgnored,
        [EnumMember(Value = "OsSourceIgnored")]
        OsSourceIgnored,
        [EnumMember(Value = "OsTriggerIgnored")]
        OsTriggerIgnored,
        [EnumMember(Value = "InvalidRegisterOsSourceHeader")]
        InvalidRegisterOsSourceHeader,
        [EnumMember(Value = "InvalidRegisterOsTriggerHeader")]
        InvalidRegisterOsTriggerHeader,
        [EnumMember(Value = "WebAndOsHeaders")]
        WebAndOsHeaders,
        [EnumMember(Value = "NoWebOrOsSupport")]
        NoWebOrOsSupport,
        [EnumMember(Value = "NavigationRegistrationWithoutTransientUserActivation")]
        NavigationRegistrationWithoutTransientUserActivation,
        [EnumMember(Value = "InvalidInfoHeader")]
        InvalidInfoHeader,
        [EnumMember(Value = "NoRegisterSourceHeader")]
        NoRegisterSourceHeader,
        [EnumMember(Value = "NoRegisterTriggerHeader")]
        NoRegisterTriggerHeader,
        [EnumMember(Value = "NoRegisterOsSourceHeader")]
        NoRegisterOsSourceHeader,
        [EnumMember(Value = "NoRegisterOsTriggerHeader")]
        NoRegisterOsTriggerHeader,
        [EnumMember(Value = "NavigationRegistrationUniqueScopeAlreadySet")]
        NavigationRegistrationUniqueScopeAlreadySet,
    }
}