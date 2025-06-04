namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests database names for given security origin.
    /// </summary>
    public sealed class RequestDatabaseNamesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.requestDatabaseNames";
        
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
    }

    public sealed class RequestDatabaseNamesCommandResponse : ICommandResponse<RequestDatabaseNamesCommand>
    {
        /// <summary>
        /// Database names for origin.
        ///</summary>
        [JsonProperty("databaseNames")]
        public string[] DatabaseNames
        {
            get;
            set;
        }
    }
}