namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the following OS state for the given manifest id.
    /// </summary>
    public sealed class GetOsAppStateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PWA.getOsAppState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The id from the webapp's manifest file, commonly it's the url of the
        /// site installing the webapp. See
        /// https://web.dev/learn/pwa/web-app-manifest.
        /// </summary>
        [JsonProperty("manifestId")]
        public string ManifestId
        {
            get;
            set;
        }
    }

    public sealed class GetOsAppStateCommandResponse : ICommandResponse<GetOsAppStateCommand>
    {
        /// <summary>
        /// Gets or sets the badgeCount
        /// </summary>
        [JsonProperty("badgeCount")]
        public long BadgeCount
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the fileHandlers
        /// </summary>
        [JsonProperty("fileHandlers")]
        public FileHandler[] FileHandlers
        {
            get;
            set;
        }
    }
}