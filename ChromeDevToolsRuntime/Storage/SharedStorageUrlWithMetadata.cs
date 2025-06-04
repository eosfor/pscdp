namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Bundles a candidate URL with its reporting metadata.
    /// </summary>
    public sealed class SharedStorageUrlWithMetadata
    {
        /// <summary>
        /// Spec of candidate URL.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Any associated reporting metadata.
        ///</summary>
        [JsonProperty("reportingMetadata")]
        public SharedStorageReportingMetadata[] ReportingMetadata
        {
            get;
            set;
        }
    }
}