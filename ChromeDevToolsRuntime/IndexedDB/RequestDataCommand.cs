namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests data from object store or index.
    /// </summary>
    public sealed class RequestDataCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.requestData";
        
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
        /// <summary>
        /// Index name, empty string for object store data requests.
        /// </summary>
        [JsonProperty("indexName")]
        public string IndexName
        {
            get;
            set;
        }
        /// <summary>
        /// Number of records to skip.
        /// </summary>
        [JsonProperty("skipCount")]
        public long SkipCount
        {
            get;
            set;
        }
        /// <summary>
        /// Number of records to fetch.
        /// </summary>
        [JsonProperty("pageSize")]
        public long PageSize
        {
            get;
            set;
        }
        /// <summary>
        /// Key range.
        /// </summary>
        [JsonProperty("keyRange", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public KeyRange KeyRange
        {
            get;
            set;
        }
    }

    public sealed class RequestDataCommandResponse : ICommandResponse<RequestDataCommand>
    {
        /// <summary>
        /// Array of object store data entries.
        ///</summary>
        [JsonProperty("objectStoreDataEntries")]
        public DataEntry[] ObjectStoreDataEntries
        {
            get;
            set;
        }
        /// <summary>
        /// If true, there are more entries to fetch in the given range.
        ///</summary>
        [JsonProperty("hasMore")]
        public bool HasMore
        {
            get;
            set;
        }
    }
}