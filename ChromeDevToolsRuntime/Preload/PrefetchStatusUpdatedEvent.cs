namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a prefetch attempt is updated.
    /// </summary>
    public sealed class PrefetchStatusUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the key
        /// </summary>
        [JsonProperty("key")]
        public PreloadingAttemptKey Key
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the pipelineId
        /// </summary>
        [JsonProperty("pipelineId")]
        public string PipelineId
        {
            get;
            set;
        }
        /// <summary>
        /// The frame id of the frame initiating prefetch.
        /// </summary>
        [JsonProperty("initiatingFrameId")]
        public string InitiatingFrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the prefetchUrl
        /// </summary>
        [JsonProperty("prefetchUrl")]
        public string PrefetchUrl
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the status
        /// </summary>
        [JsonProperty("status")]
        public PreloadingStatus Status
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the prefetchStatus
        /// </summary>
        [JsonProperty("prefetchStatus")]
        public PrefetchStatus PrefetchStatus
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the requestId
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    }
}