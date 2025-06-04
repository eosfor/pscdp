namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns when a referenced stylesheet couldn't be loaded.
    /// </summary>
    public sealed class StylesheetLoadingIssueDetails
    {
        /// <summary>
        /// Source code position that referenced the failing stylesheet.
        ///</summary>
        [JsonProperty("sourceCodeLocation")]
        public SourceCodeLocation SourceCodeLocation
        {
            get;
            set;
        }
        /// <summary>
        /// Reason why the stylesheet couldn't be loaded.
        ///</summary>
        [JsonProperty("styleSheetLoadingIssueReason")]
        public StyleSheetLoadingIssueReason StyleSheetLoadingIssueReason
        {
            get;
            set;
        }
        /// <summary>
        /// Contains additional info when the failure was due to a request.
        ///</summary>
        [JsonProperty("failedRequestInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FailedRequestInfo FailedRequestInfo
        {
            get;
            set;
        }
    }
}