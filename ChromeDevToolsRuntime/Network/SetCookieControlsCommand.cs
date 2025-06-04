namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets Controls for third-party cookie access
    /// Page reload is required before the new cookie behavior will be observed
    /// </summary>
    public sealed class SetCookieControlsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setCookieControls";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether 3pc restriction is enabled.
        /// </summary>
        [JsonProperty("enableThirdPartyCookieRestriction")]
        public bool EnableThirdPartyCookieRestriction
        {
            get;
            set;
        }
        /// <summary>
        /// Whether 3pc grace period exception should be enabled; false by default.
        /// </summary>
        [JsonProperty("disableThirdPartyCookieMetadata")]
        public bool DisableThirdPartyCookieMetadata
        {
            get;
            set;
        }
        /// <summary>
        /// Whether 3pc heuristics exceptions should be enabled; false by default.
        /// </summary>
        [JsonProperty("disableThirdPartyCookieHeuristics")]
        public bool DisableThirdPartyCookieHeuristics
        {
            get;
            set;
        }
    }

    public sealed class SetCookieControlsCommandResponse : ICommandResponse<SetCookieControlsCommand>
    {
    }
}