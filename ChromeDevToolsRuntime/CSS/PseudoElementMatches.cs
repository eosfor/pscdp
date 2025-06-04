namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS rule collection for a single pseudo style.
    /// </summary>
    public sealed class PseudoElementMatches
    {
        /// <summary>
        /// Pseudo element type.
        ///</summary>
        [JsonProperty("pseudoType")]
        public DOM.PseudoType PseudoType
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo element custom ident.
        ///</summary>
        [JsonProperty("pseudoIdentifier", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PseudoIdentifier
        {
            get;
            set;
        }
        /// <summary>
        /// Matches of CSS rules applicable to the pseudo style.
        ///</summary>
        [JsonProperty("matches")]
        public RuleMatch[] Matches
        {
            get;
            set;
        }
    }
}