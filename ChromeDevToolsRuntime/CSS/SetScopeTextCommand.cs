namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the expression of a scope at-rule.
    /// </summary>
    public sealed class SetScopeTextCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setScopeText";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the range
        /// </summary>
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the text
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    }

    public sealed class SetScopeTextCommandResponse : ICommandResponse<SetScopeTextCommand>
    {
        /// <summary>
        /// The resulting CSS Scope rule after modification.
        ///</summary>
        [JsonProperty("scope")]
        public CSSScope Scope
        {
            get;
            set;
        }
    }
}