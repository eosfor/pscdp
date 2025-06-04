namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns NodeIds of current top layer elements.
    /// Top layer is rendered closest to the user within a viewport, therefore its elements always
    /// appear on top of all other content.
    /// </summary>
    public sealed class GetTopLayerElementsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getTopLayerElements";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetTopLayerElementsCommandResponse : ICommandResponse<GetTopLayerElementsCommand>
    {
        /// <summary>
        /// NodeIds of top layer elements
        ///</summary>
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    }
}