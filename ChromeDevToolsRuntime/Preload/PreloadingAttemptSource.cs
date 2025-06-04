namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Lists sources for a preloading attempt, specifically the ids of rule sets
    /// that had a speculation rule that triggered the attempt, and the
    /// BackendNodeIds of <a href> or <area href> elements that triggered the
    /// attempt (in the case of attempts triggered by a document rule). It is
    /// possible for multiple rule sets and links to trigger a single attempt.
    /// </summary>
    public sealed class PreloadingAttemptSource
    {
        /// <summary>
        /// key
        ///</summary>
        [JsonProperty("key")]
        public PreloadingAttemptKey Key
        {
            get;
            set;
        }
        /// <summary>
        /// ruleSetIds
        ///</summary>
        [JsonProperty("ruleSetIds")]
        public string[] RuleSetIds
        {
            get;
            set;
        }
        /// <summary>
        /// nodeIds
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}