namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// FailedRequestInfo
    /// </summary>
    public sealed class FailedRequestInfo
    {
        /// <summary>
        /// The URL that failed to load.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// The failure message for the failed request.
        ///</summary>
        [JsonProperty("failureMessage")]
        public string FailureMessage
        {
            get;
            set;
        }
        /// <summary>
        /// requestId
        ///</summary>
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RequestId
        {
            get;
            set;
        }
    }
}