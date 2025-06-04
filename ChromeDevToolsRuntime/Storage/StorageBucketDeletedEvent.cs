namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// StorageBucketDeleted
    /// </summary>
    public sealed class StorageBucketDeletedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the bucketId
        /// </summary>
        [JsonProperty("bucketId")]
        public string BucketId
        {
            get;
            set;
        }
    }
}