namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired upon direct_socket.UDPSocket creation.
    /// </summary>
    public sealed class DirectUDPSocketCreatedEvent : IEvent
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
        /// Gets or sets the options
        /// </summary>
        [JsonProperty("options")]
        public DirectUDPSocketOptions Options
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