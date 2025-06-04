namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// The image definition used in both icon and screenshot.
    /// </summary>
    public sealed class ImageResource
    {
        /// <summary>
        /// The src field in the definition, but changing to url in favor of
        /// consistency.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// sizes
        ///</summary>
        [JsonProperty("sizes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Sizes
        {
            get;
            set;
        }
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }
    }
}