namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when direct_socket.TCPSocket connection is opened.
    /// </summary>
    public sealed class DirectTCPSocketOpenedEvent : IEvent
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
        /// Gets or sets the remoteAddr
        /// </summary>
        [JsonProperty("remoteAddr")]
        public string RemoteAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        /// </summary>
        [JsonProperty("remotePort")]
        public long RemotePort
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
        /// Gets or sets the localAddr
        /// </summary>
        [JsonProperty("localAddr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LocalAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        /// </summary>
        [JsonProperty("localPort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LocalPort
        {
            get;
            set;
        }
    }
}