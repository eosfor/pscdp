namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// RuleSetRemoved
    /// </summary>
    public sealed class RuleSetRemovedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }
}