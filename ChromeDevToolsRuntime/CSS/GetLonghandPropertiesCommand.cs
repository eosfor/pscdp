namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// GetLonghandProperties
    /// </summary>
    public sealed class GetLonghandPropertiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getLonghandProperties";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the shorthandName
        /// </summary>
        [JsonProperty("shorthandName")]
        public string ShorthandName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }

    public sealed class GetLonghandPropertiesCommandResponse : ICommandResponse<GetLonghandPropertiesCommand>
    {
        /// <summary>
        /// Gets or sets the longhandProperties
        /// </summary>
        [JsonProperty("longhandProperties")]
        public CSSProperty[] LonghandProperties
        {
            get;
            set;
        }
    }
}