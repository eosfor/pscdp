namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// ServiceWorkerRouterInfo
    /// </summary>
    public sealed class ServiceWorkerRouterInfo
    {
        /// <summary>
        /// ID of the rule matched. If there is a matched rule, this field will
        /// be set, otherwiser no value will be set.
        ///</summary>
        [JsonProperty("ruleIdMatched", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RuleIdMatched
        {
            get;
            set;
        }
        /// <summary>
        /// The router source of the matched rule. If there is a matched rule, this
        /// field will be set, otherwise no value will be set.
        ///</summary>
        [JsonProperty("matchedSourceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ServiceWorkerRouterSource? MatchedSourceType
        {
            get;
            set;
        }
        /// <summary>
        /// The actual router source used.
        ///</summary>
        [JsonProperty("actualSourceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ServiceWorkerRouterSource? ActualSourceType
        {
            get;
            set;
        }
    }
}