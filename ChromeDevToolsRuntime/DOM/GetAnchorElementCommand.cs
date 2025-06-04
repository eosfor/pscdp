namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the target anchor element of the given anchor query according to
    /// https://www.w3.org/TR/css-anchor-position-1/#target.
    /// </summary>
    public sealed class GetAnchorElementCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getAnchorElement";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the positioned element from which to find the anchor.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// An optional anchor specifier, as defined in
        /// https://www.w3.org/TR/css-anchor-position-1/#anchor-specifier.
        /// If not provided, it will return the implicit anchor element for
        /// the given positioned element.
        /// </summary>
        [JsonProperty("anchorSpecifier", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AnchorSpecifier
        {
            get;
            set;
        }
    }

    public sealed class GetAnchorElementCommandResponse : ICommandResponse<GetAnchorElementCommand>
    {
        /// <summary>
        /// The anchor element of the given anchor query.
        ///</summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }
}