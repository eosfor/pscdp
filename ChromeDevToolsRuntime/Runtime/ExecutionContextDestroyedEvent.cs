namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Issued when execution context is destroyed.
    /// </summary>
    public sealed class ExecutionContextDestroyedEvent : IEvent
    {
        /// <summary>
        /// Id of the destroyed context
        /// </summary>
        [JsonProperty("executionContextId")]
        public long ExecutionContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Unique Id of the destroyed context
        /// </summary>
        [JsonProperty("executionContextUniqueId")]
        public string ExecutionContextUniqueId
        {
            get;
            set;
        }
    }
}