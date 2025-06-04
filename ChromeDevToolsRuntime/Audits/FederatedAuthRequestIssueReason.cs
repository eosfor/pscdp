namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the failure reason when a federated authentication reason fails.
    /// Should be updated alongside RequestIdTokenStatus in
    /// third_party/blink/public/mojom/devtools/inspector_issue.mojom to include
    /// all cases except for success.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FederatedAuthRequestIssueReason
    {
        [EnumMember(Value = "ShouldEmbargo")]
        ShouldEmbargo,
        [EnumMember(Value = "TooManyRequests")]
        TooManyRequests,
        [EnumMember(Value = "WellKnownHttpNotFound")]
        WellKnownHttpNotFound,
        [EnumMember(Value = "WellKnownNoResponse")]
        WellKnownNoResponse,
        [EnumMember(Value = "WellKnownInvalidResponse")]
        WellKnownInvalidResponse,
        [EnumMember(Value = "WellKnownListEmpty")]
        WellKnownListEmpty,
        [EnumMember(Value = "WellKnownInvalidContentType")]
        WellKnownInvalidContentType,
        [EnumMember(Value = "ConfigNotInWellKnown")]
        ConfigNotInWellKnown,
        [EnumMember(Value = "WellKnownTooBig")]
        WellKnownTooBig,
        [EnumMember(Value = "ConfigHttpNotFound")]
        ConfigHttpNotFound,
        [EnumMember(Value = "ConfigNoResponse")]
        ConfigNoResponse,
        [EnumMember(Value = "ConfigInvalidResponse")]
        ConfigInvalidResponse,
        [EnumMember(Value = "ConfigInvalidContentType")]
        ConfigInvalidContentType,
        [EnumMember(Value = "ClientMetadataHttpNotFound")]
        ClientMetadataHttpNotFound,
        [EnumMember(Value = "ClientMetadataNoResponse")]
        ClientMetadataNoResponse,
        [EnumMember(Value = "ClientMetadataInvalidResponse")]
        ClientMetadataInvalidResponse,
        [EnumMember(Value = "ClientMetadataInvalidContentType")]
        ClientMetadataInvalidContentType,
        [EnumMember(Value = "IdpNotPotentiallyTrustworthy")]
        IdpNotPotentiallyTrustworthy,
        [EnumMember(Value = "DisabledInSettings")]
        DisabledInSettings,
        [EnumMember(Value = "DisabledInFlags")]
        DisabledInFlags,
        [EnumMember(Value = "ErrorFetchingSignin")]
        ErrorFetchingSignin,
        [EnumMember(Value = "InvalidSigninResponse")]
        InvalidSigninResponse,
        [EnumMember(Value = "AccountsHttpNotFound")]
        AccountsHttpNotFound,
        [EnumMember(Value = "AccountsNoResponse")]
        AccountsNoResponse,
        [EnumMember(Value = "AccountsInvalidResponse")]
        AccountsInvalidResponse,
        [EnumMember(Value = "AccountsListEmpty")]
        AccountsListEmpty,
        [EnumMember(Value = "AccountsInvalidContentType")]
        AccountsInvalidContentType,
        [EnumMember(Value = "IdTokenHttpNotFound")]
        IdTokenHttpNotFound,
        [EnumMember(Value = "IdTokenNoResponse")]
        IdTokenNoResponse,
        [EnumMember(Value = "IdTokenInvalidResponse")]
        IdTokenInvalidResponse,
        [EnumMember(Value = "IdTokenIdpErrorResponse")]
        IdTokenIdpErrorResponse,
        [EnumMember(Value = "IdTokenCrossSiteIdpErrorResponse")]
        IdTokenCrossSiteIdpErrorResponse,
        [EnumMember(Value = "IdTokenInvalidRequest")]
        IdTokenInvalidRequest,
        [EnumMember(Value = "IdTokenInvalidContentType")]
        IdTokenInvalidContentType,
        [EnumMember(Value = "ErrorIdToken")]
        ErrorIdToken,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "RpPageNotVisible")]
        RpPageNotVisible,
        [EnumMember(Value = "SilentMediationFailure")]
        SilentMediationFailure,
        [EnumMember(Value = "ThirdPartyCookiesBlocked")]
        ThirdPartyCookiesBlocked,
        [EnumMember(Value = "NotSignedInWithIdp")]
        NotSignedInWithIdp,
        [EnumMember(Value = "MissingTransientUserActivation")]
        MissingTransientUserActivation,
        [EnumMember(Value = "ReplacedByActiveMode")]
        ReplacedByActiveMode,
        [EnumMember(Value = "InvalidFieldsSpecified")]
        InvalidFieldsSpecified,
        [EnumMember(Value = "RelyingPartyOriginIsOpaque")]
        RelyingPartyOriginIsOpaque,
        [EnumMember(Value = "TypeNotMatching")]
        TypeNotMatching,
        [EnumMember(Value = "UiDismissedNoEmbargo")]
        UiDismissedNoEmbargo,
        [EnumMember(Value = "CorsError")]
        CorsError,
        [EnumMember(Value = "SuppressedBySegmentationPlatform")]
        SuppressedBySegmentationPlatform,
    }
}