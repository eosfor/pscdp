namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Registers storage key to be notified when an update occurs to its cache storage list.
    /// </summary>
    public sealed class TrackCacheStorageForStorageKeyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.trackCacheStorageForStorageKey";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Storage key.
        /// </summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
    }

    public sealed class TrackCacheStorageForStorageKeyCommandResponse : ICommandResponse<TrackCacheStorageForStorageKeyCommand>
    {
    }
}