namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Unregisters storage key from receiving notifications for IndexedDB.
    /// </summary>
    public sealed class UntrackIndexedDBForStorageKeyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.untrackIndexedDBForStorageKey";
        
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

    public sealed class UntrackIndexedDBForStorageKeyCommandResponse : ICommandResponse<UntrackIndexedDBForStorageKeyCommand>
    {
    }
}