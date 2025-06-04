namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Delete a range of entries from an object store
    /// </summary>
    public sealed class DeleteObjectStoreEntriesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.deleteObjectStoreEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
        /// Security origin.
        /// </summary>
        [JsonProperty("securityOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SecurityOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// Storage key.
        /// </summary>
        [JsonProperty("storageKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StorageKey
        {
            get;
            set;
        }
        /// <summary>
        /// Storage bucket. If not specified, it uses the default bucket.
        /// </summary>
        [JsonProperty("storageBucket", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Storage.StorageBucket StorageBucket
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the databaseName
        /// </summary>
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the objectStoreName
        /// </summary>
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
        /// <summary>
        /// Range of entry keys to delete
        /// </summary>
        [JsonProperty("keyRange")]
        public KeyRange KeyRange
        {
            get;
            set;
        }
    }

    public sealed class DeleteObjectStoreEntriesCommandResponse : ICommandResponse<DeleteObjectStoreEntriesCommand>
    {
    }
}