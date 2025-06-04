namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingEventTriggerData
    /// </summary>
    public sealed class AttributionReportingEventTriggerData
    {
        /// <summary>
        /// data
        ///</summary>
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
        /// <summary>
        /// priority
        ///</summary>
        [JsonProperty("priority")]
        public string Priority
        {
            get;
            set;
        }
        /// <summary>
        /// dedupKey
        ///</summary>
        [JsonProperty("dedupKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DedupKey
        {
            get;
            set;
        }
        /// <summary>
        /// filters
        ///</summary>
        [JsonProperty("filters")]
        public AttributionReportingFilterPair Filters
        {
            get;
            set;
        }
    }
}