namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cookie should have been blocked by 3PCD but is exempted and stored from a response with the
    /// corresponding reason. A cookie could only have at most one exemption reason.
    /// </summary>
    public sealed class ExemptedSetCookieWithReason
    {
        /// <summary>
        /// The reason the cookie was exempted.
        ///</summary>
        [JsonProperty("exemptionReason")]
        public CookieExemptionReason ExemptionReason
        {
            get;
            set;
        }
        /// <summary>
        /// The string representing this individual cookie as it would appear in the header.
        ///</summary>
        [JsonProperty("cookieLine")]
        public string CookieLine
        {
            get;
            set;
        }
        /// <summary>
        /// The cookie object representing the cookie.
        ///</summary>
        [JsonProperty("cookie")]
        public Cookie Cookie
        {
            get;
            set;
        }
    }
}