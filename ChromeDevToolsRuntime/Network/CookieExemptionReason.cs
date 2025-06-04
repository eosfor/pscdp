namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Types of reasons why a cookie should have been blocked by 3PCD but is exempted for the request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookieExemptionReason
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "UserSetting")]
        UserSetting,
        [EnumMember(Value = "TPCDMetadata")]
        TPCDMetadata,
        [EnumMember(Value = "TPCDDeprecationTrial")]
        TPCDDeprecationTrial,
        [EnumMember(Value = "TopLevelTPCDDeprecationTrial")]
        TopLevelTPCDDeprecationTrial,
        [EnumMember(Value = "TPCDHeuristics")]
        TPCDHeuristics,
        [EnumMember(Value = "EnterprisePolicy")]
        EnterprisePolicy,
        [EnumMember(Value = "StorageAccess")]
        StorageAccess,
        [EnumMember(Value = "TopLevelStorageAccess")]
        TopLevelStorageAccess,
        [EnumMember(Value = "Scheme")]
        Scheme,
        [EnumMember(Value = "SameSiteNoneCookiesInSandbox")]
        SameSiteNoneCookiesInSandbox,
    }
}