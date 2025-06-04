namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables streaming of the response for the given requestId.
    /// If enabled, the dataReceived event contains the data that was received during streaming.
    /// </summary>
    public sealed class StreamResourceContentCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.streamResourceContent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifier of the request to stream.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    }

    public sealed class StreamResourceContentCommandResponse : ICommandResponse<StreamResourceContentCommand>
    {
        /// <summary>
        /// Data that has been buffered until streaming is enabled.
        ///</summary>
        [JsonProperty("bufferedData")]
        public byte[] BufferedData
        {
            get;
            set;
        }
    }
}