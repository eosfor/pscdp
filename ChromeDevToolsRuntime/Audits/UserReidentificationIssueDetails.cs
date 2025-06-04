namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns about uses of APIs that may be considered misuse to
    /// re-identify users.
    /// </summary>
    public sealed class UserReidentificationIssueDetails
    {
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public UserReidentificationIssueType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Applies to BlockedFrameNavigation and BlockedSubresource issue types.
        ///</summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedRequest Request
        {
            get;
            set;
        }
    }
}