namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableValueDictEntry
    /// </summary>
    public sealed class AttributionReportingAggregatableValueDictEntry
    {
        /// <summary>
        /// key
        ///</summary>
        [JsonProperty("key")]
        public string Key
        {
            get;
            set;
        }
        /// <summary>
        /// number instead of integer because not all uint32 can be represented by
        /// int
        ///</summary>
        [JsonProperty("value")]
        public double Value
        {
            get;
            set;
        }
        /// <summary>
        /// filteringId
        ///</summary>
        [JsonProperty("filteringId")]
        public string FilteringId
        {
            get;
            set;
        }
    }
}