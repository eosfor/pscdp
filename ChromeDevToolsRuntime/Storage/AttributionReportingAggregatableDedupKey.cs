namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableDedupKey
    /// </summary>
    public sealed class AttributionReportingAggregatableDedupKey
    {
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