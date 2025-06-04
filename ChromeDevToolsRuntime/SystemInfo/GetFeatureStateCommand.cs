namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns information about the feature state.
    /// </summary>
    public sealed class GetFeatureStateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "SystemInfo.getFeatureState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the featureState
        /// </summary>
        [JsonProperty("featureState")]
        public string FeatureState
        {
            get;
            set;
        }
    }

    public sealed class GetFeatureStateCommandResponse : ICommandResponse<GetFeatureStateCommand>
    {
        /// <summary>
        /// Gets or sets the featureEnabled
        /// </summary>
        [JsonProperty("featureEnabled")]
        public bool FeatureEnabled
        {
            get;
            set;
        }
    }
}