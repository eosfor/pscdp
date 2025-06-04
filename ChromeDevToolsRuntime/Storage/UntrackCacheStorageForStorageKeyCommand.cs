namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Unregisters storage key from receiving notifications for cache storage.
    /// </summary>
    public sealed class UntrackCacheStorageForStorageKeyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.untrackCacheStorageForStorageKey";
        
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

    public sealed class UntrackCacheStorageForStorageKeyCommandResponse : ICommandResponse<UntrackCacheStorageForStorageKeyCommand>
    {
    }
}