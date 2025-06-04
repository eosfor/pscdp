namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingFilterConfig
    /// </summary>
    public sealed class AttributionReportingFilterConfig
    {
        /// <summary>
        /// filterValues
        ///</summary>
        [JsonProperty("filterValues")]
        public AttributionReportingFilterDataEntry[] FilterValues
        {
            get;
            set;
        }
        /// <summary>
        /// duration in seconds
        ///</summary>
        [JsonProperty("lookbackWindow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LookbackWindow
        {
            get;
            set;
        }
    }
}