namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests database with given name in given frame.
    /// </summary>
    public sealed class RequestDatabaseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.requestDatabase";
        
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
    }

    public sealed class RequestDatabaseCommandResponse : ICommandResponse<RequestDatabaseCommand>
    {
        /// <summary>
        /// Database with an array of object stores.
        ///</summary>
        [JsonProperty("databaseWithObjectStores")]
        public DatabaseWithObjectStores DatabaseWithObjectStores
        {
            get;
            set;
        }
    }
}