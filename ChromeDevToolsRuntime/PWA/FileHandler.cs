namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// FileHandler
    /// </summary>
    public sealed class FileHandler
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
        /// accepts
        ///</summary>
        [JsonProperty("accepts")]
        public FileHandlerAccept[] Accepts
        {
            get;
            set;
        }
        /// <summary>
        /// displayName
        ///</summary>
        [JsonProperty("displayName")]
        public string DisplayName
        {
            get;
            set;
        }
    }
}