namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingTriggerRegistered
    /// </summary>
    public sealed class AttributionReportingTriggerRegisteredEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the registration
        /// </summary>
        [JsonProperty("registration")]
        public AttributionReportingTriggerRegistration Registration
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the eventLevel
        /// </summary>
        [JsonProperty("eventLevel")]
        public AttributionReportingEventLevelResult EventLevel
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the aggregatable
        /// </summary>
        [JsonProperty("aggregatable")]
        public AttributionReportingAggregatableResult Aggregatable
        {
            get;
            set;
        }
    }
}