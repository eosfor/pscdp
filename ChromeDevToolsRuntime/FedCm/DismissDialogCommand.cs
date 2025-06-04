namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// DismissDialog
    /// </summary>
    public sealed class DismissDialogCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.dismissDialog";
        
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
        /// Gets or sets the triggerCooldown
        /// </summary>
        [JsonProperty("triggerCooldown", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? TriggerCooldown
        {
            get;
            set;
        }
    }

    public sealed class DismissDialogCommandResponse : ICommandResponse<DismissDialogCommand>
    {
    }
}