namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears all entries for a given origin's shared storage.
    /// </summary>
    public sealed class ClearSharedStorageEntriesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.clearSharedStorageEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the ownerOrigin
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
    }

    public sealed class ClearSharedStorageEntriesCommandResponse : ICommandResponse<ClearSharedStorageEntriesCommand>
    {
    }
}