namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingAggregatableDebugReportingData
    /// </summary>
    public sealed class AttributionReportingAggregatableDebugReportingData
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
        /// types
        ///</summary>
        [JsonProperty("types")]
        public string[] Types
        {
            get;
            set;
        }
    }
}