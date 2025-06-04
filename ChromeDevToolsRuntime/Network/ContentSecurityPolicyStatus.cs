namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// ContentSecurityPolicyStatus
    /// </summary>
    public sealed class ContentSecurityPolicyStatus
    {
        /// <summary>
        /// effectiveDirectives
        ///</summary>
        [JsonProperty("effectiveDirectives")]
        public string EffectiveDirectives
        {
            get;
            set;
        }
        /// <summary>
        /// isEnforced
        ///</summary>
        [JsonProperty("isEnforced")]
        public bool IsEnforced
        {
            get;
            set;
        }
        /// <summary>
        /// source
        ///</summary>
        [JsonProperty("source")]
        public ContentSecurityPolicySource Source
        {
            get;
            set;
        }
    }
}