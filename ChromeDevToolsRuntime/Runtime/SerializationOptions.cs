namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents options for serialization. Overrides `generatePreview` and `returnByValue`.
    /// </summary>
    public sealed class SerializationOptions
    {
        /// <summary>
        /// serialization
        ///</summary>
        [JsonProperty("serialization")]
        public string Serialization
        {
            get;
            set;
        }
        /// <summary>
        /// Deep serialization depth. Default is full depth. Respected only in `deep` serialization mode.
        ///</summary>
        [JsonProperty("maxDepth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? MaxDepth
        {
            get;
            set;
        }
        /// <summary>
        /// Embedder-specific parameters. For example if connected to V8 in Chrome these control DOM
        /// serialization via `maxNodeDepth: integer` and `includeShadowTree: "none" | "open" | "all"`.
        /// Values can be only of type string or integer.
        ///</summary>
        [JsonProperty("additionalParameters", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object AdditionalParameters
        {
            get;
            set;
        }
    }
}