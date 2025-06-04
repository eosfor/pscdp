namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Activates emulation of network conditions.
    /// </summary>
    public sealed class EmulateNetworkConditionsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.emulateNetworkConditions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// True to emulate internet disconnection.
        /// </summary>
        [JsonProperty("offline")]
        public bool Offline
        {
            get;
            set;
        }
        /// <summary>
        /// Minimum latency from request sent to response headers received (ms).
        /// </summary>
        [JsonProperty("latency")]
        public double Latency
        {
            get;
            set;
        }
        /// <summary>
        /// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
        /// </summary>
        [JsonProperty("downloadThroughput")]
        public double DownloadThroughput
        {
            get;
            set;
        }
        /// <summary>
        /// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
        /// </summary>
        [JsonProperty("uploadThroughput")]
        public double UploadThroughput
        {
            get;
            set;
        }
        /// <summary>
        /// Connection type if known.
        /// </summary>
        [JsonProperty("connectionType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConnectionType? ConnectionType
        {
            get;
            set;
        }
        /// <summary>
        /// WebRTC packet loss (percent, 0-100). 0 disables packet loss emulation, 100 drops all the packets.
        /// </summary>
        [JsonProperty("packetLoss", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? PacketLoss
        {
            get;
            set;
        }
        /// <summary>
        /// WebRTC packet queue length (packet). 0 removes any queue length limitations.
        /// </summary>
        [JsonProperty("packetQueueLength", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? PacketQueueLength
        {
            get;
            set;
        }
        /// <summary>
        /// WebRTC packetReordering feature.
        /// </summary>
        [JsonProperty("packetReordering", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? PacketReordering
        {
            get;
            set;
        }
    }

    public sealed class EmulateNetworkConditionsCommandResponse : ICommandResponse<EmulateNetworkConditionsCommand>
    {
    }
}