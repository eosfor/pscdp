namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SafeAreaInsets
    /// </summary>
    public sealed class SafeAreaInsets
    {
        /// <summary>
        /// Overrides safe-area-inset-top.
        ///</summary>
        [JsonProperty("top", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Top
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-max-inset-top.
        ///</summary>
        [JsonProperty("topMax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? TopMax
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-inset-left.
        ///</summary>
        [JsonProperty("left", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Left
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-max-inset-left.
        ///</summary>
        [JsonProperty("leftMax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LeftMax
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-inset-bottom.
        ///</summary>
        [JsonProperty("bottom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Bottom
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-max-inset-bottom.
        ///</summary>
        [JsonProperty("bottomMax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BottomMax
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-inset-right.
        ///</summary>
        [JsonProperty("right", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Right
        {
            get;
            set;
        }
        /// <summary>
        /// Overrides safe-area-max-inset-right.
        ///</summary>
        [JsonProperty("rightMax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? RightMax
        {
            get;
            set;
        }
    }
}