namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// DirectTCPSocketOptions
    /// </summary>
    public sealed class DirectTCPSocketOptions
    {
        /// <summary>
        /// TCP_NODELAY option
        ///</summary>
        [JsonProperty("noDelay")]
        public bool NoDelay
        {
            get;
            set;
        }
        /// <summary>
        /// Expected to be unsigned integer.
        ///</summary>
        [JsonProperty("keepAliveDelay", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? KeepAliveDelay
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
        /// <summary>
        /// dnsQueryType
        ///</summary>
        [JsonProperty("dnsQueryType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DirectSocketDnsQueryType? DnsQueryType
        {
            get;
            set;
        }
    }
}