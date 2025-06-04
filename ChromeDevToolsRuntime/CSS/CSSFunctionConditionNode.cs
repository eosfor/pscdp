namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS function conditional block representation.
    /// </summary>
    public sealed class CSSFunctionConditionNode
    {
        /// <summary>
        /// Media query for this conditional block. Only one type of condition should be set.
        ///</summary>
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSMedia Media
        {
            get;
            set;
        }
        /// <summary>
        /// Container query for this conditional block. Only one type of condition should be set.
        ///</summary>
        [JsonProperty("containerQueries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSContainerQuery ContainerQueries
        {
            get;
            set;
        }
        /// <summary>
        /// @supports CSS at-rule condition. Only one type of condition should be set.
        ///</summary>
        [JsonProperty("supports", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSSupports Supports
        {
            get;
            set;
        }
        /// <summary>
        /// Block body.
        ///</summary>
        [JsonProperty("children")]
        public CSSFunctionNode[] Children
        {
            get;
            set;
        }
        /// <summary>
        /// The condition text.
        ///</summary>
        [JsonProperty("conditionText")]
        public string ConditionText
        {
            get;
            set;
        }
    }
}