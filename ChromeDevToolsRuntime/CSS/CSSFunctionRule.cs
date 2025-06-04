namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS function at-rule representation.
    /// </summary>
    public sealed class CSSFunctionRule
    {
        /// <summary>
        /// Name of the function.
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
        /// List of parameters.
        ///</summary>
        [JsonProperty("parameters")]
        public CSSFunctionParameter[] Parameters
        {
            get;
            set;
        }
        /// <summary>
        /// Function body.
        ///</summary>
        [JsonProperty("children")]
        public CSSFunctionNode[] Children
        {
            get;
            set;
        }
    }
}