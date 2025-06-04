namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a node's scrollability state changes.
    /// </summary>
    public sealed class ScrollableFlagUpdatedEvent : IEvent
    {
        /// <summary>
        /// The id of the node.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// If the node is scrollable.
        /// </summary>
        [JsonProperty("isScrollable")]
        public bool IsScrollable
        {
            get;
            set;
        }
    }
}