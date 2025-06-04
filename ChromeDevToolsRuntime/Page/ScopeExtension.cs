namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// ScopeExtension
    /// </summary>
    public sealed class ScopeExtension
    {
        /// <summary>
        /// Instead of using tuple, this field always returns the serialized string
        /// for easy understanding and comparison.
        ///</summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// hasOriginWildcard
        ///</summary>
        [JsonProperty("hasOriginWildcard")]
        public bool HasOriginWildcard
        {
            get;
            set;
        }
    }
}