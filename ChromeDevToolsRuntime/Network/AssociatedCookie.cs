namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cookie associated with the request which may or may not be sent with it.
    /// Includes the cookies itself and reasons for blocking or exemption.
    /// </summary>
    public sealed class AssociatedCookie
    {
        /// <summary>
        /// The cookie object representing the cookie which was not sent.
        ///</summary>
        [JsonProperty("cookie")]
        public Cookie Cookie
        {
            get;
            set;
        }
        /// <summary>
        /// The reason(s) the cookie was blocked. If empty means the cookie is included.
        ///</summary>
        [JsonProperty("blockedReasons")]
        public CookieBlockedReason[] BlockedReasons
        {
            get;
            set;
        }
        /// <summary>
        /// The reason the cookie should have been blocked by 3PCD but is exempted. A cookie could
        /// only have at most one exemption reason.
        ///</summary>
        [JsonProperty("exemptionReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CookieExemptionReason? ExemptionReason
        {
            get;
            set;
        }
    }
}