namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Upsert. Currently, it is only emitted when a rule set added.
    /// </summary>
    public sealed class RuleSetUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the ruleSet
        /// </summary>
        [JsonProperty("ruleSet")]
        public RuleSet RuleSet
        {
            get;
            set;
        }
    }
}