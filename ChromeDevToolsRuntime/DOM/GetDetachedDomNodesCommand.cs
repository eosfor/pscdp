namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns list of detached nodes
    /// </summary>
    public sealed class GetDetachedDomNodesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getDetachedDomNodes";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetDetachedDomNodesCommandResponse : ICommandResponse<GetDetachedDomNodesCommand>
    {
        /// <summary>
        /// The list of detached nodes
        ///</summary>
        [JsonProperty("detachedNodes")]
        public DetachedElementInfo[] DetachedNodes
        {
            get;
            set;
        }
    }
}