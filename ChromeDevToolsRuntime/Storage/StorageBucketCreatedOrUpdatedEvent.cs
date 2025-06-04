namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// StorageBucketCreatedOrUpdated
    /// </summary>
    public sealed class StorageBucketCreatedOrUpdatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the bucketInfo
        /// </summary>
        [JsonProperty("bucketInfo")]
        public StorageBucketInfo BucketInfo
        {
            get;
            set;
        }
    }
}