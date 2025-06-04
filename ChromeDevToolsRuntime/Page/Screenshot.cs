namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Screenshot
    /// </summary>
    public sealed class Screenshot
    {
        /// <summary>
        /// image
        ///</summary>
        [JsonProperty("image")]
        public ImageResource Image
        {
            get;
            set;
        }
        /// <summary>
        /// formFactor
        ///</summary>
        [JsonProperty("formFactor")]
        public string FormFactor
        {
            get;
            set;
        }
        /// <summary>
        /// label
        ///</summary>
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }
    }
}