namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Given a CSS selector text and a style sheet ID, getLocationForSelector
    /// returns an array of locations of the CSS selector in the style sheet.
    /// </summary>
    public sealed class GetLocationForSelectorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getLocationForSelector";
        
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
        /// Gets or sets the selectorText
        /// </summary>
        [JsonProperty("selectorText")]
        public string SelectorText
        {
            get;
            set;
        }
    }

    public sealed class GetLocationForSelectorCommandResponse : ICommandResponse<GetLocationForSelectorCommand>
    {
        /// <summary>
        /// Gets or sets the ranges
        /// </summary>
        [JsonProperty("ranges")]
        public SourceRange[] Ranges
        {
            get;
            set;
        }
    }
}