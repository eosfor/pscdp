namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sends all pending Attribution Reports immediately, regardless of their
    /// scheduled report time.
    /// </summary>
    public sealed class SendPendingAttributionReportsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.sendPendingAttributionReports";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class SendPendingAttributionReportsCommandResponse : ICommandResponse<SendPendingAttributionReportsCommand>
    {
        /// <summary>
        /// The number of reports that were sent.
        ///</summary>
        [JsonProperty("numSent")]
        public long NumSent
        {
            get;
            set;
        }
    }
}