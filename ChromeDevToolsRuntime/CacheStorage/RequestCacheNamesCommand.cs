namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests cache names.
    /// </summary>
    public sealed class RequestCacheNamesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.requestCacheNames";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// At least and at most one of securityOrigin, storageKey, storageBucket must be specified.
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

    public sealed class RequestCacheNamesCommandResponse : ICommandResponse<RequestCacheNamesCommand>
    {
        /// <summary>
        /// Caches for the security origin.
        ///</summary>
        [JsonProperty("caches")]
        public Cache[] Caches
        {
            get;
            set;
        }
    }
}