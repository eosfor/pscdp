namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the property rule property name.
    /// </summary>
    public sealed class SetPropertyRulePropertyNameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setPropertyRulePropertyName";
        
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
        /// Gets or sets the propertyName
        /// </summary>
        [JsonProperty("propertyName")]
        public string PropertyName
        {
            get;
            set;
        }
    }

    public sealed class SetPropertyRulePropertyNameCommandResponse : ICommandResponse<SetPropertyRulePropertyNameCommand>
    {
        /// <summary>
        /// The resulting key text after modification.
        ///</summary>
        [JsonProperty("propertyName")]
        public Value PropertyName
        {
            get;
            set;
        }
    }
}