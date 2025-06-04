namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingFilterDataEntry
    /// </summary>
    public sealed class AttributionReportingFilterDataEntry
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
        /// values
        ///</summary>
        [JsonProperty("values")]
        public string[] Values
        {
            get;
            set;
        }
    }
}