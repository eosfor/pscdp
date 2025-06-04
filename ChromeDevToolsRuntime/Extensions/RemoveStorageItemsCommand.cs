namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes `keys` from extension storage in the given `storageArea`.
    /// </summary>
    public sealed class RemoveStorageItemsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Extensions.removeStorageItems";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// ID of extension.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// StorageArea to remove data from.
        /// </summary>
        [JsonProperty("storageArea")]
        public StorageArea StorageArea
        {
            get;
            set;
        }
        /// <summary>
        /// Keys to remove.
        /// </summary>
        [JsonProperty("keys")]
        public string[] Keys
        {
            get;
            set;
        }
    }

    public sealed class RemoveStorageItemsCommandResponse : ICommandResponse<RemoveStorageItemsCommand>
    {
    }
}