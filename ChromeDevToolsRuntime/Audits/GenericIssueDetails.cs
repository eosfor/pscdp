namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Depending on the concrete errorType, different properties are set.
    /// </summary>
    public sealed class GenericIssueDetails
    {
        /// <summary>
        /// Issues with the same errorType are aggregated in the frontend.
        ///</summary>
        [JsonProperty("errorType")]
        public GenericIssueErrorType ErrorType
        {
            get;
            set;
        }
        /// <summary>
        /// frameId
        ///</summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// violatingNodeId
        ///</summary>
        [JsonProperty("violatingNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ViolatingNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// violatingNodeAttribute
        ///</summary>
        [JsonProperty("violatingNodeAttribute", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ViolatingNodeAttribute
        {
            get;
            set;
        }
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedRequest Request
        {
            get;
            set;
        }
    }
}