namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// ShareTarget
    /// </summary>
    public sealed class ShareTarget
    {
        /// <summary>
        /// action
        ///</summary>
        [JsonProperty("action")]
        public string Action
        {
            get;
            set;
        }
        /// <summary>
        /// method
        ///</summary>
        [JsonProperty("method")]
        public string Method
        {
            get;
            set;
        }
        /// <summary>
        /// enctype
        ///</summary>
        [JsonProperty("enctype")]
        public string Enctype
        {
            get;
            set;
        }
        /// <summary>
        /// Embed the ShareTargetParams
        ///</summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// text
        ///</summary>
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// files
        ///</summary>
        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FileFilter[] Files
        {
            get;
            set;
        }
    }
}