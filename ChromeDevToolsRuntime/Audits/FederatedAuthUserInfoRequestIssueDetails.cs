namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// FederatedAuthUserInfoRequestIssueDetails
    /// </summary>
    public sealed class FederatedAuthUserInfoRequestIssueDetails
    {
        /// <summary>
        /// federatedAuthUserInfoRequestIssueReason
        ///</summary>
        [JsonProperty("federatedAuthUserInfoRequestIssueReason")]
        public FederatedAuthUserInfoRequestIssueReason FederatedAuthUserInfoRequestIssueReason
        {
            get;
            set;
        }
    }
}