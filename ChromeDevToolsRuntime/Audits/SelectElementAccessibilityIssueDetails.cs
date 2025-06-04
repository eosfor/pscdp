namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns about errors in the select element content model.
    /// </summary>
    public sealed class SelectElementAccessibilityIssueDetails
    {
        /// <summary>
        /// nodeId
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// selectElementAccessibilityIssueReason
        ///</summary>
        [JsonProperty("selectElementAccessibilityIssueReason")]
        public SelectElementAccessibilityIssueReason SelectElementAccessibilityIssueReason
        {
            get;
            set;
        }
        /// <summary>
        /// hasDisallowedAttributes
        ///</summary>
        [JsonProperty("hasDisallowedAttributes")]
        public bool HasDisallowedAttributes
        {
            get;
            set;
        }
    }
}