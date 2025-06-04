namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears storage for storage key.
    /// </summary>
    public sealed class ClearDataForStorageKeyCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.clearDataForStorageKey";
        
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
        /// <summary>
        /// Comma separated list of StorageType to clear.
        /// </summary>
        [JsonProperty("storageTypes")]
        public string StorageTypes
        {
            get;
            set;
        }
    }

    public sealed class ClearDataForStorageKeyCommandResponse : ICommandResponse<ClearDataForStorageKeyCommand>
    {
    }
}