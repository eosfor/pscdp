namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configures encryption keys used with a given privacy sandbox API to talk
    /// to a trusted coordinator.  Since this is intended for test automation only,
    /// coordinatorOrigin must be a .test domain. No existing coordinator
    /// configuration for the origin may exist.
    /// </summary>
    public sealed class AddPrivacySandboxCoordinatorKeyConfigCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Browser.addPrivacySandboxCoordinatorKeyConfig";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the api
        /// </summary>
        [JsonProperty("api")]
        public PrivacySandboxAPI Api
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the coordinatorOrigin
        /// </summary>
        [JsonProperty("coordinatorOrigin")]
        public string CoordinatorOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the keyConfig
        /// </summary>
        [JsonProperty("keyConfig")]
        public string KeyConfig
        {
            get;
            set;
        }
        /// <summary>
        /// BrowserContext to perform the action in. When omitted, default browser
        /// context is used.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
    }

    public sealed class AddPrivacySandboxCoordinatorKeyConfigCommandResponse : ICommandResponse<AddPrivacySandboxCoordinatorKeyConfigCommand>
    {
    }
}