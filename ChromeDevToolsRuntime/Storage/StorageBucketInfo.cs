namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// StorageBucketInfo
    /// </summary>
    public sealed class StorageBucketInfo
    {
        /// <summary>
        /// bucket
        ///</summary>
        [JsonProperty("bucket")]
        public StorageBucket Bucket
        {
            get;
            set;
        }
        /// <summary>
        /// id
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// expiration
        ///</summary>
        [JsonProperty("expiration")]
        public double Expiration
        {
            get;
            set;
        }
        /// <summary>
        /// Storage quota (bytes).
        ///</summary>
        [JsonProperty("quota")]
        public double Quota
        {
            get;
            set;
        }
        /// <summary>
        /// persistent
        ///</summary>
        [JsonProperty("persistent")]
        public bool Persistent
        {
            get;
            set;
        }
        /// <summary>
        /// durability
        ///</summary>
        [JsonProperty("durability")]
        public StorageBucketsDurability Durability
        {
            get;
            set;
        }
    }
}