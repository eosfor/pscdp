namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set tracking for a storage key's buckets.
    /// </summary>
    public sealed class SetStorageBucketTrackingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setStorageBucketTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the storageKey
        /// </summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the enable
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable
        {
            get;
            set;
        }
    }

    public sealed class SetStorageBucketTrackingCommandResponse : ICommandResponse<SetStorageBucketTrackingCommand>
    {
    }
}