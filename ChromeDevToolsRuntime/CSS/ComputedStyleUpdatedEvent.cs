namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// ComputedStyleUpdated
    /// </summary>
    public sealed class ComputedStyleUpdatedEvent : IEvent
    {
        /// <summary>
        /// The node id that has updated computed styles.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}