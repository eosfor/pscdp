namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the query container of the given node based on container query
    /// conditions: containerName, physical and logical axes, and whether it queries
    /// scroll-state. If no axes are provided and queriesScrollState is false, the
    /// style container is returned, which is the direct parent or the closest
    /// element with a matching container-name.
    /// </summary>
    public sealed class GetContainerForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getContainerForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the containerName
        /// </summary>
        [JsonProperty("containerName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContainerName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the physicalAxes
        /// </summary>
        [JsonProperty("physicalAxes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhysicalAxes? PhysicalAxes
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the logicalAxes
        /// </summary>
        [JsonProperty("logicalAxes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LogicalAxes? LogicalAxes
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the queriesScrollState
        /// </summary>
        [JsonProperty("queriesScrollState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? QueriesScrollState
        {
            get;
            set;
        }
    }

    public sealed class GetContainerForNodeCommandResponse : ICommandResponse<GetContainerForNodeCommand>
    {
        /// <summary>
        /// The container node for the given node, or null if not found.
        ///</summary>
        [JsonProperty("nodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NodeId
        {
            get;
            set;
        }
    }
}