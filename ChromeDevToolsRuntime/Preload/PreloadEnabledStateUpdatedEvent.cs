namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a preload enabled state is updated.
    /// </summary>
    public sealed class PreloadEnabledStateUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the disabledByPreference
        /// </summary>
        [JsonProperty("disabledByPreference")]
        public bool DisabledByPreference
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the disabledByDataSaver
        /// </summary>
        [JsonProperty("disabledByDataSaver")]
        public bool DisabledByDataSaver
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the disabledByBatterySaver
        /// </summary>
        [JsonProperty("disabledByBatterySaver")]
        public bool DisabledByBatterySaver
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the disabledByHoldbackPrefetchSpeculationRules
        /// </summary>
        [JsonProperty("disabledByHoldbackPrefetchSpeculationRules")]
        public bool DisabledByHoldbackPrefetchSpeculationRules
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the disabledByHoldbackPrerenderSpeculationRules
        /// </summary>
        [JsonProperty("disabledByHoldbackPrerenderSpeculationRules")]
        public bool DisabledByHoldbackPrerenderSpeculationRules
        {
            get;
            set;
        }
    }
}