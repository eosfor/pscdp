namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes state for sites identified as potential bounce trackers, immediately.
    /// </summary>
    public sealed class RunBounceTrackingMitigationsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.runBounceTrackingMitigations";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class RunBounceTrackingMitigationsCommandResponse : ICommandResponse<RunBounceTrackingMitigationsCommand>
    {
        /// <summary>
        /// Gets or sets the deletedSites
        /// </summary>
        [JsonProperty("deletedSites")]
        public string[] DeletedSites
        {
            get;
            set;
        }
    }
}