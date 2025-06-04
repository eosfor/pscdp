namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    public sealed class CancelPromptCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceAccess.cancelPrompt";
        
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
    }

    public sealed class CancelPromptCommandResponse : ICommandResponse<CancelPromptCommand>
    {
    }
}