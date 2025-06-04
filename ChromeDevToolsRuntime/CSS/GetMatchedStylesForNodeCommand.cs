namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns requested styles for a DOM node identified by `nodeId`.
    /// </summary>
    public sealed class GetMatchedStylesForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getMatchedStylesForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetMatchedStylesForNodeCommandResponse : ICommandResponse<GetMatchedStylesForNodeCommand>
    {
        /// <summary>
        /// Inline style for the specified DOM node.
        ///</summary>
        [JsonProperty("inlineStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle InlineStyle
        {
            get;
            set;
        }
        /// <summary>
        /// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
        ///</summary>
        [JsonProperty("attributesStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle AttributesStyle
        {
            get;
            set;
        }
        /// <summary>
        /// CSS rules matching this node, from all applicable stylesheets.
        ///</summary>
        [JsonProperty("matchedCSSRules", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RuleMatch[] MatchedCSSRules
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo style matches for this node.
        ///</summary>
        [JsonProperty("pseudoElements", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PseudoElementMatches[] PseudoElements
        {
            get;
            set;
        }
        /// <summary>
        /// A chain of inherited styles (from the immediate node parent up to the DOM tree root).
        ///</summary>
        [JsonProperty("inherited", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InheritedStyleEntry[] Inherited
        {
            get;
            set;
        }
        /// <summary>
        /// A chain of inherited pseudo element styles (from the immediate node parent up to the DOM tree root).
        ///</summary>
        [JsonProperty("inheritedPseudoElements", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InheritedPseudoElementMatches[] InheritedPseudoElements
        {
            get;
            set;
        }
        /// <summary>
        /// A list of CSS keyframed animations matching this node.
        ///</summary>
        [JsonProperty("cssKeyframesRules", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSKeyframesRule[] CssKeyframesRules
        {
            get;
            set;
        }
        /// <summary>
        /// A list of CSS @position-try rules matching this node, based on the position-try-fallbacks property.
        ///</summary>
        [JsonProperty("cssPositionTryRules", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSPositionTryRule[] CssPositionTryRules
        {
            get;
            set;
        }
        /// <summary>
        /// Index of the active fallback in the applied position-try-fallback property,
        /// will not be set if there is no active position-try fallback.
        ///</summary>
        [JsonProperty("activePositionFallbackIndex", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ActivePositionFallbackIndex
        {
            get;
            set;
        }
        /// <summary>
        /// A list of CSS at-property rules matching this node.
        ///</summary>
        [JsonProperty("cssPropertyRules", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSPropertyRule[] CssPropertyRules
        {
            get;
            set;
        }
        /// <summary>
        /// A list of CSS property registrations matching this node.
        ///</summary>
        [JsonProperty("cssPropertyRegistrations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSPropertyRegistration[] CssPropertyRegistrations
        {
            get;
            set;
        }
        /// <summary>
        /// A font-palette-values rule matching this node.
        ///</summary>
        [JsonProperty("cssFontPaletteValuesRule", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSFontPaletteValuesRule CssFontPaletteValuesRule
        {
            get;
            set;
        }
        /// <summary>
        /// Id of the first parent element that does not have display: contents.
        ///</summary>
        [JsonProperty("parentLayoutNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ParentLayoutNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// A list of CSS at-function rules referenced by styles of this node.
        ///</summary>
        [JsonProperty("cssFunctionRules", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSFunctionRule[] CssFunctionRules
        {
            get;
            set;
        }
    }
}