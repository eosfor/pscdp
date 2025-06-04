namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about the suggested solution to a cookie issue.
    /// </summary>
    public sealed class CookieIssueInsight
    {
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public InsightType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Link to table entry in third-party cookie migration readiness list.
        ///</summary>
        [JsonProperty("tableEntryUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TableEntryUrl
        {
            get;
            set;
        }
    }
}