namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS rule representation.
    /// </summary>
    public sealed class CSSRule
    {
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified
        /// stylesheet rules) this rule came from.
        ///</summary>
        [JsonProperty("styleSheetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Rule selector data.
        ///</summary>
        [JsonProperty("selectorList")]
        public SelectorList SelectorList
        {
            get;
            set;
        }
        /// <summary>
        /// Array of selectors from ancestor style rules, sorted by distance from the current rule.
        ///</summary>
        [JsonProperty("nestingSelectors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] NestingSelectors
        {
            get;
            set;
        }
        /// <summary>
        /// Parent stylesheet's origin.
        ///</summary>
        [JsonProperty("origin")]
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Associated style declaration.
        ///</summary>
        [JsonProperty("style")]
        public CSSStyle Style
        {
            get;
            set;
        }
        /// <summary>
        /// Media list array (for rules involving media queries). The array enumerates media queries
        /// starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSMedia[] Media
        {
            get;
            set;
        }
        /// <summary>
        /// Container query list array (for rules involving container queries).
        /// The array enumerates container queries starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("containerQueries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSContainerQuery[] ContainerQueries
        {
            get;
            set;
        }
        /// <summary>
        /// @supports CSS at-rule array.
        /// The array enumerates @supports at-rules starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("supports", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSSupports[] Supports
        {
            get;
            set;
        }
        /// <summary>
        /// Cascade layer array. Contains the layer hierarchy that this rule belongs to starting
        /// with the innermost layer and going outwards.
        ///</summary>
        [JsonProperty("layers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSLayer[] Layers
        {
            get;
            set;
        }
        /// <summary>
        /// @scope CSS at-rule array.
        /// The array enumerates @scope at-rules starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("scopes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSScope[] Scopes
        {
            get;
            set;
        }
        /// <summary>
        /// The array keeps the types of ancestor CSSRules from the innermost going outwards.
        ///</summary>
        [JsonProperty("ruleTypes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSRuleType[] RuleTypes
        {
            get;
            set;
        }
        /// <summary>
        /// @starting-style CSS at-rule array.
        /// The array enumerates @starting-style at-rules starting with the innermost one, going outwards.
        ///</summary>
        [JsonProperty("startingStyles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStartingStyle[] StartingStyles
        {
            get;
            set;
        }
    }
}