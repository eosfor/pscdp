namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables page domain notifications.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If true, the `Page.fileChooserOpened` event will be emitted regardless of the state set by
        /// `Page.setInterceptFileChooserDialog` command (default: false).
        /// </summary>
        [JsonProperty("enableFileChooserOpenedEvent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableFileChooserOpenedEvent
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}