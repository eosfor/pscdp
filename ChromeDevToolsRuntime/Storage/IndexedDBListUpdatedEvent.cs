namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// The origin's IndexedDB database list has been modified.
    /// </summary>
    public sealed class IndexedDBListUpdatedEvent : IEvent
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