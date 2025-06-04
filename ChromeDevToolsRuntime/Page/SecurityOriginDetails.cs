namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Additional information about the frame document's security origin.
    /// </summary>
    public sealed class SecurityOriginDetails
    {
        /// <summary>
        /// Indicates whether the frame document's security origin is one
        /// of the local hostnames (e.g. "localhost") or IP addresses (IPv4
        /// 127.0.0.0/8 or IPv6 ::1).
        ///</summary>
        [JsonProperty("isLocalhost")]
        public bool IsLocalhost
        {
            get;
            set;
        }
    }
}