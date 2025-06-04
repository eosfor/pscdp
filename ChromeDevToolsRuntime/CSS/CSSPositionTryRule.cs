namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS @position-try rule representation.
    /// </summary>
    public sealed class CSSPositionTryRule
    {
        /// <summary>
        /// The prelude dashed-ident name
        ///</summary>
        [JsonProperty("name")]
        public Value Name
        {
            get;
            set;
        }
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
        /// Associated style declaration.
        ///</summary>
        [JsonProperty("style")]
        public CSSStyle Style
        {
            get;
            set;
        }
        /// <summary>
        /// active
        ///</summary>
        [JsonProperty("active")]
        public bool Active
        {
            get;
            set;
        }
    }
}