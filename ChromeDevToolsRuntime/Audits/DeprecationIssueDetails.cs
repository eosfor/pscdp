namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// This issue tracks information needed to print a deprecation message.
    /// https://source.chromium.org/chromium/chromium/src/+/main:third_party/blink/renderer/core/frame/third_party/blink/renderer/core/frame/deprecation/README.md
    /// </summary>
    public sealed class DeprecationIssueDetails
    {
        /// <summary>
        /// affectedFrame
        ///</summary>
        [JsonProperty("affectedFrame", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AffectedFrame AffectedFrame
        {
            get;
            set;
        }
        /// <summary>
        /// sourceCodeLocation
        ///</summary>
        [JsonProperty("sourceCodeLocation")]
        public SourceCodeLocation SourceCodeLocation
        {
            get;
            set;
        }
        /// <summary>
        /// One of the deprecation names from third_party/blink/renderer/core/frame/deprecation/deprecation.json5
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}