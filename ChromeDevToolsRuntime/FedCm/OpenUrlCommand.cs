namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// OpenUrl
    /// </summary>
    public sealed class OpenUrlCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.openUrl";
        
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
        /// <summary>
        /// Gets or sets the accountUrlType
        /// </summary>
        [JsonProperty("accountUrlType")]
        public AccountUrlType AccountUrlType
        {
            get;
            set;
        }
    }

    public sealed class OpenUrlCommandResponse : ICommandResponse<OpenUrlCommand>
    {
    }
}