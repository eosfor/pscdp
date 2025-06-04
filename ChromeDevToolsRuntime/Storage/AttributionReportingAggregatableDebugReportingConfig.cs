namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableDebugReportingConfig
    /// </summary>
    public sealed class AttributionReportingAggregatableDebugReportingConfig
    {
        /// <summary>
        /// number instead of integer because not all uint32 can be represented by
        /// int, only present for source registrations
        ///</summary>
        [JsonProperty("budget", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Budget
        {
            get;
            set;
        }
        /// <summary>
        /// keyPiece
        ///</summary>
        [JsonProperty("keyPiece")]
        public string KeyPiece
        {
            get;
            set;
        }
        /// <summary>
        /// debugData
        ///</summary>
        [JsonProperty("debugData")]
        public AttributionReportingAggregatableDebugReportingData[] DebugData
        {
            get;
            set;
        }
        /// <summary>
        /// aggregationCoordinatorOrigin
        ///</summary>
        [JsonProperty("aggregationCoordinatorOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AggregationCoordinatorOrigin
        {
            get;
            set;
        }
    }
}