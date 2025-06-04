namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cache's contents have been modified.
    /// </summary>
    public sealed class CacheStorageContentUpdatedEvent : IEvent
    {
        /// <summary>
        /// Origin to update.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
        /// <summary>
        /// Storage key to update.
        /// </summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
        /// <summary>
        /// Storage bucket to update.
        /// </summary>
        [JsonProperty("bucketId")]
        public string BucketId
        {
            get;
            set;
        }
        /// <summary>
        /// Name of cache in origin.
        /// </summary>
        [JsonProperty("cacheName")]
        public string CacheName
        {
            get;
            set;
        }
    }
}