namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// RelatedApplication
    /// </summary>
    public sealed class RelatedApplication
    {
        /// <summary>
        /// id
        ///</summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    }
}