namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the failure reason when a getUserInfo() call fails.
    /// Should be updated alongside FederatedAuthUserInfoRequestResult in
    /// third_party/blink/public/mojom/devtools/inspector_issue.mojom.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FederatedAuthUserInfoRequestIssueReason
    {
        [EnumMember(Value = "NotSameOrigin")]
        NotSameOrigin,
        [EnumMember(Value = "NotIframe")]
        NotIframe,
        [EnumMember(Value = "NotPotentiallyTrustworthy")]
        NotPotentiallyTrustworthy,
        [EnumMember(Value = "NoApiPermission")]
        NoApiPermission,
        [EnumMember(Value = "NotSignedInWithIdp")]
        NotSignedInWithIdp,
        [EnumMember(Value = "NoAccountSharingPermission")]
        NoAccountSharingPermission,
        [EnumMember(Value = "InvalidConfigOrWellKnown")]
        InvalidConfigOrWellKnown,
        [EnumMember(Value = "InvalidAccountsResponse")]
        InvalidAccountsResponse,
        [EnumMember(Value = "NoReturningUserFromFetchedAccounts")]
        NoReturningUserFromFetchedAccounts,
    }
}