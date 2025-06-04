namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// ProtocolHandler
    /// </summary>
    public sealed class ProtocolHandler
    {
        /// <summary>
        /// protocol
        ///</summary>
        [JsonProperty("protocol")]
        public string Protocol
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