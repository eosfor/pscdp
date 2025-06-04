namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS property at-rule representation.
    /// </summary>
    public sealed class CSSPropertyRule
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
        /// Parent stylesheet's origin.
        ///</summary>
        [JsonProperty("origin")]
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Associated property name.
        ///</summary>
        [JsonProperty("propertyName")]
        public Value PropertyName
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
    }
}