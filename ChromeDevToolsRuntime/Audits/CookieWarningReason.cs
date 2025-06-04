namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// CookieWarningReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookieWarningReason
    {
        [EnumMember(Value = "WarnSameSiteUnspecifiedCrossSiteContext")]
        WarnSameSiteUnspecifiedCrossSiteContext,
        [EnumMember(Value = "WarnSameSiteNoneInsecure")]
        WarnSameSiteNoneInsecure,
        [EnumMember(Value = "WarnSameSiteUnspecifiedLaxAllowUnsafe")]
        WarnSameSiteUnspecifiedLaxAllowUnsafe,
        [EnumMember(Value = "WarnSameSiteStrictLaxDowngradeStrict")]
        WarnSameSiteStrictLaxDowngradeStrict,
        [EnumMember(Value = "WarnSameSiteStrictCrossDowngradeStrict")]
        WarnSameSiteStrictCrossDowngradeStrict,
        [EnumMember(Value = "WarnSameSiteStrictCrossDowngradeLax")]
        WarnSameSiteStrictCrossDowngradeLax,
        [EnumMember(Value = "WarnSameSiteLaxCrossDowngradeStrict")]
        WarnSameSiteLaxCrossDowngradeStrict,
        [EnumMember(Value = "WarnSameSiteLaxCrossDowngradeLax")]
        WarnSameSiteLaxCrossDowngradeLax,
        [EnumMember(Value = "WarnAttributeValueExceedsMaxSize")]
        WarnAttributeValueExceedsMaxSize,
        [EnumMember(Value = "WarnDomainNonASCII")]
        WarnDomainNonASCII,
        [EnumMember(Value = "WarnThirdPartyPhaseout")]
        WarnThirdPartyPhaseout,
        [EnumMember(Value = "WarnCrossSiteRedirectDowngradeChangesInclusion")]
        WarnCrossSiteRedirectDowngradeChangesInclusion,
        [EnumMember(Value = "WarnDeprecationTrialMetadata")]
        WarnDeprecationTrialMetadata,
        [EnumMember(Value = "WarnThirdPartyCookieHeuristic")]
        WarnThirdPartyCookieHeuristic,
    }
}