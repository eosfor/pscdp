namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a prerender attempt is updated.
    /// </summary>
    public sealed class PrerenderStatusUpdatedEvent : IEvent
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
        /// Gets or sets the status
        /// </summary>
        [JsonProperty("status")]
        public PreloadingStatus Status
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the prerenderStatus
        /// </summary>
        [JsonProperty("prerenderStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PrerenderFinalStatus? PrerenderStatus
        {
            get;
            set;
        }
        /// <summary>
        /// This is used to give users more information about the name of Mojo interface
        /// that is incompatible with prerender and has caused the cancellation of the attempt.
        /// </summary>
        [JsonProperty("disallowedMojoInterface", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DisallowedMojoInterface
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the mismatchedHeaders
        /// </summary>
        [JsonProperty("mismatchedHeaders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PrerenderMismatchedHeaders[] MismatchedHeaders
        {
            get;
            set;
        }
    }
}