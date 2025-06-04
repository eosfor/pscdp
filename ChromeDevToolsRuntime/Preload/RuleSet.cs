namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;

    /// <summary>
    /// Corresponds to SpeculationRuleSet
    /// </summary>
    public sealed class RuleSet
    {
        /// <summary>
        /// id
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Identifies a document which the rule set is associated with.
        ///</summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// Source text of JSON representing the rule set. If it comes from
        /// `<script>` tag, it is the textContent of the node. Note that it is
        /// a JSON for valid case.
        /// 
        /// See also:
        /// - https://wicg.github.io/nav-speculation/speculation-rules.html
        /// - https://github.com/WICG/nav-speculation/blob/main/triggers.md
        ///</summary>
        [JsonProperty("sourceText")]
        public string SourceText
        {
            get;
            set;
        }
        /// <summary>
        /// A speculation rule set is either added through an inline
        /// `<script>` tag or through an external resource via the
        /// 'Speculation-Rules' HTTP header. For the first case, we include
        /// the BackendNodeId of the relevant `<script>` tag. For the second
        /// case, we include the external URL where the rule set was loaded
        /// from, and also RequestId if Network domain is enabled.
        /// 
        /// See also:
        /// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-script
        /// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-header
        ///</summary>
        [JsonProperty("backendNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? BackendNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// url
        ///</summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// requestId
        ///</summary>
        [JsonProperty("requestId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// Error information
        /// `errorMessage` is null iff `errorType` is null.
        ///</summary>
        [JsonProperty("errorType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RuleSetErrorType? ErrorType
        {
            get;
            set;
        }
        /// <summary>
        /// TODO(https://crbug.com/1425354): Replace this property with structured error.
        ///</summary>
        [JsonProperty("errorMessage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}