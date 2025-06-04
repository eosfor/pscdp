namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// DirectUDPSocketOptions
    /// </summary>
    public sealed class DirectUDPSocketOptions
    {
        /// <summary>
        /// remoteAddr
        ///</summary>
        [JsonProperty("remoteAddr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RemoteAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Unsigned int 16.
        ///</summary>
        [JsonProperty("remotePort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RemotePort
        {
            get;
            set;
        }
        /// <summary>
        /// localAddr
        ///</summary>
        [JsonProperty("localAddr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LocalAddr
        {
            get;
            set;
        }
        /// <summary>
        /// Unsigned int 16.
        ///</summary>
        [JsonProperty("localPort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LocalPort
        {
            get;
            set;
        }
        /// <summary>
        /// dnsQueryType
        ///</summary>
        [JsonProperty("dnsQueryType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DirectSocketDnsQueryType? DnsQueryType
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        ///</summary>
        [JsonProperty("sendBufferSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? SendBufferSize
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        ///</summary>
        [JsonProperty("receiveBufferSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? ReceiveBufferSize
        {
            get;
            set;
        }
    }
}