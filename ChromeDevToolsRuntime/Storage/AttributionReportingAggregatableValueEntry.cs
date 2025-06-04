namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableValueEntry
    /// </summary>
    public sealed class AttributionReportingAggregatableValueEntry
    {
        /// <summary>
        /// values
        ///</summary>
        [JsonProperty("values")]
        public AttributionReportingAggregatableValueDictEntry[] Values
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