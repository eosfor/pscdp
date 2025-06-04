namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue warns about sites in the redirect chain of a finished navigation
    /// that may be flagged as trackers and have their state cleared if they don't
    /// receive a user interaction. Note that in this context 'site' means eTLD+1.
    /// For example, if the URL `https://example.test:80/bounce` was in the
    /// redirect chain, the site reported would be `example.test`.
    /// </summary>
    public sealed class BounceTrackingIssueDetails
    {
        /// <summary>
        /// trackingSites
        ///</summary>
        [JsonProperty("trackingSites")]
        public string[] TrackingSites
        {
            get;
            set;
        }
    }
}