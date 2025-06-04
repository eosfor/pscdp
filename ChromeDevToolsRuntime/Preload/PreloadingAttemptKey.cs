namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// A key that identifies a preloading attempt.
    /// 
    /// The url used is the url specified by the trigger (i.e. the initial URL), and
    /// not the final url that is navigated to. For example, prerendering allows
    /// same-origin main frame navigations during the attempt, but the attempt is
    /// still keyed with the initial URL.
    /// </summary>
    public sealed class PreloadingAttemptKey
    {
        /// <summary>
        /// loaderId
        ///</summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// action
        ///</summary>
        [JsonProperty("action")]
        public SpeculationAction Action
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// targetHint
        ///</summary>
        [JsonProperty("targetHint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SpeculationTargetHint? TargetHint
        {
            get;
            set;
        }
    }
}