namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable the WebAuthn domain and start intercepting credential storage and
    /// retrieval with a virtual authenticator.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Whether to enable the WebAuthn user interface. Enabling the UI is
        /// recommended for debugging and demo purposes, as it is closer to the real
        /// experience. Disabling the UI is recommended for automated testing.
        /// Supported at the embedder's discretion if UI is available.
        /// Defaults to false.
        /// </summary>
        [JsonProperty("enableUI", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableUI
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}