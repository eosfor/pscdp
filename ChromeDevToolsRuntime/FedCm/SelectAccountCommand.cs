namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// SelectAccount
    /// </summary>
    public sealed class SelectAccountCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.selectAccount";
        
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
        /// Gets or sets the accountIndex
        /// </summary>
        [JsonProperty("accountIndex")]
        public long AccountIndex
        {
            get;
            set;
        }
    }

    public sealed class SelectAccountCommandResponse : ICommandResponse<SelectAccountCommand>
    {
    }
}