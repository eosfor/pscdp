namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information of headers to be displayed when the header mismatch occurred.
    /// </summary>
    public sealed class PrerenderMismatchedHeaders
    {
        /// <summary>
        /// headerName
        ///</summary>
        [JsonProperty("headerName")]
        public string HeaderName
        {
            get;
            set;
        }
        /// <summary>
        /// initialValue
        ///</summary>
        [JsonProperty("initialValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InitialValue
        {
            get;
            set;
        }
        /// <summary>
        /// activationValue
        ///</summary>
        [JsonProperty("activationValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ActivationValue
        {
            get;
            set;
        }
    }
}