namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableTriggerData
    /// </summary>
    public sealed class AttributionReportingAggregatableTriggerData
    {
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
        /// sourceKeys
        ///</summary>
        [JsonProperty("sourceKeys")]
        public string[] SourceKeys
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