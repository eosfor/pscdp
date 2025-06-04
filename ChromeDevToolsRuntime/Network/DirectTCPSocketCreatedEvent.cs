namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired upon direct_socket.TCPSocket creation.
    /// </summary>
    public sealed class DirectTCPSocketCreatedEvent : IEvent
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
        /// Unsigned int 16.
        /// </summary>
        [JsonProperty("remotePort")]
        public long RemotePort
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the options
        /// </summary>
        [JsonProperty("options")]
        public DirectTCPSocketOptions Options
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
        /// Gets or sets the initiator
        /// </summary>
        [JsonProperty("initiator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Initiator Initiator
        {
            get;
            set;
        }
    }
}