namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingReportSent
    /// </summary>
    public sealed class AttributionReportingReportSentEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the url
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the body
        /// </summary>
        [JsonProperty("body")]
        public object Body
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the result
        /// </summary>
        [JsonProperty("result")]
        public AttributionReportingReportResult Result
        {
            get;
            set;
        }
        /// <summary>
        /// If result is `sent`, populated with net/HTTP status.
        /// </summary>
        [JsonProperty("netError", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NetError
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the netErrorName
        /// </summary>
        [JsonProperty("netErrorName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NetErrorName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the httpStatusCode
        /// </summary>
        [JsonProperty("httpStatusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? HttpStatusCode
        {
            get;
            set;
        }
    }
}