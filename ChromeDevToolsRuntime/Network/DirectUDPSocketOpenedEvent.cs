namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when direct_socket.UDPSocket connection is opened.
    /// </summary>
    public sealed class DirectUDPSocketOpenedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the localAddr
        /// </summary>
        [JsonProperty("localAddr")]
        public string LocalAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        /// </summary>
        [JsonProperty("localPort")]
        public long LocalPort
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the remoteAddr
        /// </summary>
        [JsonProperty("remoteAddr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RemoteAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        /// </summary>
        [JsonProperty("remotePort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RemotePort
        {
            get;
            set;
        }
    }
}