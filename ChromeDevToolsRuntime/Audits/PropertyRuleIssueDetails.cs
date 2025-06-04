namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns about errors in property rules that lead to property
    /// registrations being ignored.
    /// </summary>
    public sealed class PropertyRuleIssueDetails
    {
        /// <summary>
        /// Source code position of the property rule.
        ///</summary>
        [JsonProperty("sourceCodeLocation")]
        public SourceCodeLocation SourceCodeLocation
        {
            get;
            set;
        }
        /// <summary>
        /// Reason why the property rule was discarded.
        ///</summary>
        [JsonProperty("propertyRuleIssueReason")]
        public PropertyRuleIssueReason PropertyRuleIssueReason
        {
            get;
            set;
        }
        /// <summary>
        /// The value of the property rule property that failed to parse
        ///</summary>
        [JsonProperty("propertyValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PropertyValue
        {
            get;
            set;
        }
    }
}