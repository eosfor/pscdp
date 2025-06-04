namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// cookiePartitionKey object
    /// The representation of the components of the key that are created by the cookiePartitionKey class contained in net/cookies/cookie_partition_key.h.
    /// </summary>
    public sealed class CookiePartitionKey
    {
        /// <summary>
        /// The site of the top-level URL the browser was visiting at the start
        /// of the request to the endpoint that set the cookie.
        ///</summary>
        [JsonProperty("topLevelSite")]
        public string TopLevelSite
        {
            get;
            set;
        }
        /// <summary>
        /// Indicates if the cookie has any ancestors that are cross-site to the topLevelSite.
        ///</summary>
        [JsonProperty("hasCrossSiteAncestor")]
        public bool HasCrossSiteAncestor
        {
            get;
            set;
        }
    }
}