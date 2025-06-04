namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingFilterPair
    /// </summary>
    public sealed class AttributionReportingFilterPair
    {
        /// <summary>
        /// filters
        ///</summary>
        [JsonProperty("filters")]
        public AttributionReportingFilterConfig[] Filters
        {
            get;
            set;
        }
        /// <summary>
        /// notFilters
        ///</summary>
        [JsonProperty("notFilters")]
        public AttributionReportingFilterConfig[] NotFilters
        {
            get;
            set;
        }
    }
}