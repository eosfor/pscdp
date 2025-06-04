namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Applies specified style edits one after another in the given order.
    /// </summary>
    public sealed class SetStyleTextsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setStyleTexts";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the edits
        /// </summary>
        [JsonProperty("edits")]
        public StyleDeclarationEdit[] Edits
        {
            get;
            set;
        }
        /// <summary>
        /// NodeId for the DOM node in whose context custom property declarations for registered properties should be
        /// validated. If omitted, declarations in the new rule text can only be validated statically, which may produce
        /// incorrect results if the declaration contains a var() for example.
        /// </summary>
        [JsonProperty("nodeForPropertySyntaxValidation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeForPropertySyntaxValidation
        {
            get;
            set;
        }
    }

    public sealed class SetStyleTextsCommandResponse : ICommandResponse<SetStyleTextsCommand>
    {
        /// <summary>
        /// The resulting styles after modification.
        ///</summary>
        [JsonProperty("styles")]
        public CSSStyle[] Styles
        {
            get;
            set;
        }
    }
}