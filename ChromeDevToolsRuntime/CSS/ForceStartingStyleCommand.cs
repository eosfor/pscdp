namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Ensures that the given node is in its starting-style state.
    /// </summary>
    public sealed class ForceStartingStyleCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.forceStartingStyle";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The element id for which to force the starting-style state.
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Boolean indicating if this is on or off.
        /// </summary>
        [JsonProperty("forced")]
        public bool Forced
        {
            get;
            set;
        }
    }

    public sealed class ForceStartingStyleCommandResponse : ICommandResponse<ForceStartingStyleCommand>
    {
    }
}