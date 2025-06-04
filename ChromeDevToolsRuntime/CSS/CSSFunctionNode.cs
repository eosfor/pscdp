namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Section of the body of a CSS function rule.
    /// </summary>
    public sealed class CSSFunctionNode
    {
        /// <summary>
        /// A conditional block. If set, style should not be set.
        ///</summary>
        [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSFunctionConditionNode Condition
        {
            get;
            set;
        }
        /// <summary>
        /// Values set by this node. If set, condition should not be set.
        ///</summary>
        [JsonProperty("style", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle Style
        {
            get;
            set;
        }
    }
}