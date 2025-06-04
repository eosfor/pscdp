namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// A cache has been added/deleted.
    /// </summary>
    public sealed class CacheStorageListUpdatedEvent : IEvent
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
    }
}