namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns about third-party sites that are accessing cookies on the
    /// current page, and have been permitted due to having a global metadata grant.
    /// Note that in this context 'site' means eTLD+1. For example, if the URL
    /// `https://example.test:80/web_page` was accessing cookies, the site reported
    /// would be `example.test`.
    /// </summary>
    public sealed class CookieDeprecationMetadataIssueDetails
    {
        /// <summary>
        /// allowedSites
        ///</summary>
        [JsonProperty("allowedSites")]
        public string[] AllowedSites
        {
            get;
            set;
        }
        /// <summary>
        /// optOutPercentage
        ///</summary>
        [JsonProperty("optOutPercentage")]
        public double OptOutPercentage
        {
            get;
            set;
        }
        /// <summary>
        /// isOptOutTopLevel
        ///</summary>
        [JsonProperty("isOptOutTopLevel")]
        public bool IsOptOutTopLevel
        {
            get;
            set;
        }
        /// <summary>
        /// operation
        ///</summary>
        [JsonProperty("operation")]
        public CookieOperation Operation
        {
            get;
            set;
        }
    }
}