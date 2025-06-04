namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears extension storage in the given `storageArea`.
    /// </summary>
    public sealed class ClearStorageItemsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Extensions.clearStorageItems";
        
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
    }

    public sealed class ClearStorageItemsCommandResponse : ICommandResponse<ClearStorageItemsCommand>
    {
    }
}