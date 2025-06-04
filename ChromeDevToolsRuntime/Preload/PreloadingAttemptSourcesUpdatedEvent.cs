namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Send a list of sources for all preloading attempts in a document.
    /// </summary>
    public sealed class PreloadingAttemptSourcesUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the loaderId
        /// </summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the preloadingAttemptSources
        /// </summary>
        [JsonProperty("preloadingAttemptSources")]
        public PreloadingAttemptSource[] PreloadingAttemptSources
        {
            get;
            set;
        }
    }
}