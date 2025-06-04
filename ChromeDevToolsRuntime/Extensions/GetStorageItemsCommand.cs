namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets data from extension storage in the given `storageArea`. If `keys` is
    /// specified, these are used to filter the result.
    /// </summary>
    public sealed class GetStorageItemsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Extensions.getStorageItems";
        
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
        /// StorageArea to retrieve data from.
        /// </summary>
        [JsonProperty("storageArea")]
        public StorageArea StorageArea
        {
            get;
            set;
        }
        /// <summary>
        /// Keys to retrieve.
        /// </summary>
        [JsonProperty("keys", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Keys
        {
            get;
            set;
        }
    }

    public sealed class GetStorageItemsCommandResponse : ICommandResponse<GetStorageItemsCommand>
    {
        /// <summary>
        /// Gets or sets the data
        /// </summary>
        [JsonProperty("data")]
        public object Data
        {
            get;
            set;
        }
    }
}