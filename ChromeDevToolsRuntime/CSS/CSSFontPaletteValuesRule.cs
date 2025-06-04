namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS font-palette-values rule representation.
    /// </summary>
    public sealed class CSSFontPaletteValuesRule
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
        /// Associated font palette name.
        ///</summary>
        [JsonProperty("fontPaletteName")]
        public Value FontPaletteName
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