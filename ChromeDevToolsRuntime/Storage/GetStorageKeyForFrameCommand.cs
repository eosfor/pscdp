namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns a storage key given a frame id.
    /// </summary>
    public sealed class GetStorageKeyForFrameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getStorageKeyForFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the frameId
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetStorageKeyForFrameCommandResponse : ICommandResponse<GetStorageKeyForFrameCommand>
    {
        /// <summary>
        /// Gets or sets the storageKey
        /// </summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
    }
}