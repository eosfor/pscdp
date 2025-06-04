namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingSourceRegistered
    /// </summary>
    public sealed class AttributionReportingSourceRegisteredEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the registration
        /// </summary>
        [JsonProperty("registration")]
        public AttributionReportingSourceRegistration Registration
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the result
        /// </summary>
        [JsonProperty("result")]
        public AttributionReportingSourceRegistrationResult Result
        {
            get;
            set;
        }
    }
}