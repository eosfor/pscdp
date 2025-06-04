namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Allows callers to disable the promise rejection delay that would
        /// normally happen, if this is unimportant to what's being tested.
        /// (step 4 of https://fedidcg.github.io/FedCM/#browser-api-rp-sign-in)
        /// </summary>
        [JsonProperty("disableRejectionDelay", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableRejectionDelay
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}