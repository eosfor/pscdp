namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS Starting Style at-rule descriptor.
    /// </summary>
    public sealed class CSSStartingStyle
    {
        /// <summary>
        /// The associated rule header range in the enclosing stylesheet (if
        /// available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the stylesheet containing this object (if exists).
        ///</summary>
        [JsonProperty("styleSheetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StyleSheetId
        {
            get;
            set;
        }
    }
}