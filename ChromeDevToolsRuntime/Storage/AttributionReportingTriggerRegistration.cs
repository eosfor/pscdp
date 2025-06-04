namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingTriggerRegistration
    /// </summary>
    public sealed class AttributionReportingTriggerRegistration
    {
        /// <summary>
        /// filters
        ///</summary>
        [JsonProperty("filters")]
        public AttributionReportingFilterPair Filters
        {
            get;
            set;
        }
        /// <summary>
        /// debugKey
        ///</summary>
        [JsonProperty("debugKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DebugKey
        {
            get;
            set;
        }
        /// <summary>
        /// aggregatableDedupKeys
        ///</summary>
        [JsonProperty("aggregatableDedupKeys")]
        public AttributionReportingAggregatableDedupKey[] AggregatableDedupKeys
        {
            get;
            set;
        }
        /// <summary>
        /// eventTriggerData
        ///</summary>
        [JsonProperty("eventTriggerData")]
        public AttributionReportingEventTriggerData[] EventTriggerData
        {
            get;
            set;
        }
        /// <summary>
        /// aggregatableTriggerData
        ///</summary>
        [JsonProperty("aggregatableTriggerData")]
        public AttributionReportingAggregatableTriggerData[] AggregatableTriggerData
        {
            get;
            set;
        }
        /// <summary>
        /// aggregatableValues
        ///</summary>
        [JsonProperty("aggregatableValues")]
        public AttributionReportingAggregatableValueEntry[] AggregatableValues
        {
            get;
            set;
        }
        /// <summary>
        /// aggregatableFilteringIdMaxBytes
        ///</summary>
        [JsonProperty("aggregatableFilteringIdMaxBytes")]
        public long AggregatableFilteringIdMaxBytes
        {
            get;
            set;
        }
        /// <summary>
        /// debugReporting
        ///</summary>
        [JsonProperty("debugReporting")]
        public bool DebugReporting
        {
            get;
            set;
        }
        /// <summary>
        /// aggregationCoordinatorOrigin
        ///</summary>
        [JsonProperty("aggregationCoordinatorOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AggregationCoordinatorOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// sourceRegistrationTimeConfig
        ///</summary>
        [JsonProperty("sourceRegistrationTimeConfig")]
        public AttributionReportingSourceRegistrationTimeConfig SourceRegistrationTimeConfig
        {
            get;
            set;
        }
        /// <summary>
        /// triggerContextId
        ///</summary>
        [JsonProperty("triggerContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TriggerContextId
        {
            get;
            set;
        }
        /// <summary>
        /// aggregatableDebugReportingConfig
        ///</summary>
        [JsonProperty("aggregatableDebugReportingConfig")]
        public AttributionReportingAggregatableDebugReportingConfig AggregatableDebugReportingConfig
        {
            get;
            set;
        }
        /// <summary>
        /// scopes
        ///</summary>
        [JsonProperty("scopes")]
        public string[] Scopes
        {
            get;
            set;
        }
        /// <summary>
        /// namedBudgets
        ///</summary>
        [JsonProperty("namedBudgets")]
        public AttributionReportingNamedBudgetCandidate[] NamedBudgets
        {
            get;
            set;
        }
    }
}