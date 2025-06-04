namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a dictionary object passed in as privateAggregationConfig to
    /// run or selectURL.
    /// </summary>
    public sealed class SharedStoragePrivateAggregationConfig
    {
        /// <summary>
        /// The chosen aggregation service deployment.
        ///</summary>
        [JsonProperty("aggregationCoordinatorOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AggregationCoordinatorOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// The context ID provided.
        ///</summary>
        [JsonProperty("contextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Configures the maximum size allowed for filtering IDs.
        ///</summary>
        [JsonProperty("filteringIdMaxBytes")]
        public long FilteringIdMaxBytes
        {
            get;
            set;
        }
        /// <summary>
        /// The limit on the number of contributions in the final report.
        ///</summary>
        [JsonProperty("maxContributions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxContributions
        {
            get;
            set;
        }
    }
}