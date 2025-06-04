namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    public sealed class SelectPromptCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceAccess.selectPrompt";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the deviceId
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId
        {
            get;
            set;
        }
    }

    public sealed class SelectPromptCommandResponse : ICommandResponse<SelectPromptCommand>
    {
    }
}