namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Retruns DOM object counters after preparing renderer for leak detection.
    /// </summary>
    public sealed class GetDOMCountersForLeakDetectionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.getDOMCountersForLeakDetection";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetDOMCountersForLeakDetectionCommandResponse : ICommandResponse<GetDOMCountersForLeakDetectionCommand>
    {
        /// <summary>
        /// DOM object counters.
        ///</summary>
        [JsonProperty("counters")]
        public DOMCounter[] Counters
        {
            get;
            set;
        }
    }
}