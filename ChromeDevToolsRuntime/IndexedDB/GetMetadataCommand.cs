namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets metadata of an object store.
    /// </summary>
    public sealed class GetMetadataCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.getMetadata";
        
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
        /// Database name.
        /// </summary>
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
        /// <summary>
        /// Object store name.
        /// </summary>
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
    }

    public sealed class GetMetadataCommandResponse : ICommandResponse<GetMetadataCommand>
    {
        /// <summary>
        /// the entries count
        ///</summary>
        [JsonProperty("entriesCount")]
        public double EntriesCount
        {
            get;
            set;
        }
        /// <summary>
        /// the current value of key generator, to become the next inserted
        /// key into the object store. Valid if objectStore.autoIncrement
        /// is true.
        ///</summary>
        [JsonProperty("keyGeneratorValue")]
        public double KeyGeneratorValue
        {
            get;
            set;
        }
    }
}