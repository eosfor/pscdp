namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets the entries in an given origin's shared storage.
    /// </summary>
    public sealed class GetSharedStorageEntriesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getSharedStorageEntries";
        
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

    public sealed class GetSharedStorageEntriesCommandResponse : ICommandResponse<GetSharedStorageEntriesCommand>
    {
        /// <summary>
        /// Gets or sets the entries
        /// </summary>
        [JsonProperty("entries")]
        public SharedStorageEntry[] Entries
        {
            get;
            set;
        }
    }
}