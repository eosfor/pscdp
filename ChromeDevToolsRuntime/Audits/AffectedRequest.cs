namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about a request that is affected by an inspector issue.
    /// </summary>
    public sealed class AffectedRequest
    {
        /// <summary>
        /// The unique request id.
        ///</summary>
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    }
}