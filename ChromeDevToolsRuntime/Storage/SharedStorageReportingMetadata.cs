namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Pair of reporting metadata details for a candidate URL for `selectURL()`.
    /// </summary>
    public sealed class SharedStorageReportingMetadata
    {
        /// <summary>
        /// eventType
        ///</summary>
        [JsonProperty("eventType")]
        public string EventType
        {
            get;
            set;
        }
        /// <summary>
        /// reportingUrl
        ///</summary>
        [JsonProperty("reportingUrl")]
        public string ReportingUrl
        {
            get;
            set;
        }
    }
}