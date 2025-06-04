namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Extensions for Custom Handlers API:
    /// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
    /// </summary>
    public sealed class SetRPHRegistrationModeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setRPHRegistrationMode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the mode
        /// </summary>
        [JsonProperty("mode")]
        public AutoResponseMode Mode
        {
            get;
            set;
        }
    }

    public sealed class SetRPHRegistrationModeCommandResponse : ICommandResponse<SetRPHRegistrationModeCommand>
    {
    }
}