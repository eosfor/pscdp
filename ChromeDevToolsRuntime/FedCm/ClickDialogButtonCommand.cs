namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// ClickDialogButton
    /// </summary>
    public sealed class ClickDialogButtonCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.clickDialogButton";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the dialogId
        /// </summary>
        [JsonProperty("dialogId")]
        public string DialogId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the dialogButton
        /// </summary>
        [JsonProperty("dialogButton")]
        public DialogButton DialogButton
        {
            get;
            set;
        }
    }

    public sealed class ClickDialogButtonCommandResponse : ICommandResponse<ClickDialogButtonCommand>
    {
    }
}