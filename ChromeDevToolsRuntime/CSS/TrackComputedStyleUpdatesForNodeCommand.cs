namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Starts tracking the given node for the computed style updates
    /// and whenever the computed style is updated for node, it queues
    /// a `computedStyleUpdated` event with throttling.
    /// There can only be 1 node tracked for computed style updates
    /// so passing a new node id removes tracking from the previous node.
    /// Pass `undefined` to disable tracking.
    /// </summary>
    public sealed class TrackComputedStyleUpdatesForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.trackComputedStyleUpdatesForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
    }

    public sealed class TrackComputedStyleUpdatesForNodeCommandResponse : ICommandResponse<TrackComputedStyleUpdatesForNodeCommand>
    {
    }
}