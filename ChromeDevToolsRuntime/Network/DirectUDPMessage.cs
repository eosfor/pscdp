namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// DirectUDPMessage
    /// </summary>
    public sealed class DirectUDPMessage
    {
        /// <summary>
        /// data
        ///</summary>
        [JsonProperty("data")]
        public byte[] Data
        {
            get;
            set;
        }
        /// <summary>
        /// Null for connected mode.
        ///</summary>
        [JsonProperty("remoteAddr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RemoteAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Null for connected mode.
        /// Expected to be unsigned integer.
        ///</summary>
        [JsonProperty("remotePort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RemotePort
        {
            get;
            set;
        }
    }
}