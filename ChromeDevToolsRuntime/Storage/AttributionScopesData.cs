namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionScopesData
    /// </summary>
    public sealed class AttributionScopesData
    {
        /// <summary>
        /// values
        ///</summary>
        [JsonProperty("values")]
        public string[] Values
        {
            get;
            set;
        }
        /// <summary>
        /// number instead of integer because not all uint32 can be represented by
        /// int
        ///</summary>
        [JsonProperty("limit")]
        public double Limit
        {
            get;
            set;
        }
        /// <summary>
        /// maxEventStates
        ///</summary>
        [JsonProperty("maxEventStates")]
        public double MaxEventStates
        {
            get;
            set;
        }
    }
}