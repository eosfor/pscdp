namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingSourceRegistration
    /// </summary>
    public sealed class AttributionReportingSourceRegistration
    {
        /// <summary>
        /// time
        ///</summary>
        [JsonProperty("time")]
        public double Time
        {
            get;
            set;
        }
        /// <summary>
        /// duration in seconds
        ///</summary>
        [JsonProperty("expiry")]
        public long Expiry
        {
            get;
            set;
        }
        /// <summary>
        /// number instead of integer because not all uint32 can be represented by
        /// int
        ///</summary>
        [JsonProperty("triggerData")]
        public double[] TriggerData
        {
            get;
            set;
        }
        /// <summary>
        /// eventReportWindows
        ///</summary>
        [JsonProperty("eventReportWindows")]
        public AttributionReportingEventReportWindows EventReportWindows
        {
            get;
            set;
        }
        /// <summary>
        /// duration in seconds
        ///</summary>
        [JsonProperty("aggregatableReportWindow")]
        public long AggregatableReportWindow
        {
            get;
            set;
        }
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public AttributionReportingSourceType Type
        {
            get;
            set;
        }
        /// <summary>
        /// sourceOrigin
        ///</summary>
        [JsonProperty("sourceOrigin")]
        public string SourceOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// reportingOrigin
        ///</summary>
        [JsonProperty("reportingOrigin")]
        public string ReportingOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// destinationSites
        ///</summary>
        [JsonProperty("destinationSites")]
        public string[] DestinationSites
        {
            get;
            set;
        }
        /// <summary>
        /// eventId
        ///</summary>
        [JsonProperty("eventId")]
        public string EventId
        {
            get;
            set;
        }
        /// <summary>
        /// priority
        ///</summary>
        [JsonProperty("priority")]
        public string Priority
        {
            get;
            set;
        }
        /// <summary>
        /// filterData
        ///</summary>
        [JsonProperty("filterData")]
        public AttributionReportingFilterDataEntry[] FilterData
        {
            get;
            set;
        }
        /// <summary>
        /// aggregationKeys
        ///</summary>
        [JsonProperty("aggregationKeys")]
        public AttributionReportingAggregationKeysEntry[] AggregationKeys
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
        /// triggerDataMatching
        ///</summary>
        [JsonProperty("triggerDataMatching")]
        public AttributionReportingTriggerDataMatching TriggerDataMatching
        {
            get;
            set;
        }
        /// <summary>
        /// destinationLimitPriority
        ///</summary>
        [JsonProperty("destinationLimitPriority")]
        public string DestinationLimitPriority
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
        /// scopesData
        ///</summary>
        [JsonProperty("scopesData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AttributionScopesData ScopesData
        {
            get;
            set;
        }
        /// <summary>
        /// maxEventLevelReports
        ///</summary>
        [JsonProperty("maxEventLevelReports")]
        public long MaxEventLevelReports
        {
            get;
            set;
        }
        /// <summary>
        /// namedBudgets
        ///</summary>
        [JsonProperty("namedBudgets")]
        public AttributionReportingNamedBudgetDef[] NamedBudgets
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
        /// eventLevelEpsilon
        ///</summary>
        [JsonProperty("eventLevelEpsilon")]
        public double EventLevelEpsilon
        {
            get;
            set;
        }
    }
}