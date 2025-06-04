namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Details for an origin's shared storage.
    /// </summary>
    public sealed class SharedStorageMetadata
    {
        /// <summary>
        /// Time when the origin's shared storage was last created.
        ///</summary>
        [JsonProperty("creationTime")]
        public double CreationTime
        {
            get;
            set;
        }
        /// <summary>
        /// Number of key-value pairs stored in origin's shared storage.
        ///</summary>
        [JsonProperty("length")]
        public long Length
        {
            get;
            set;
        }
        /// <summary>
        /// Current amount of bits of entropy remaining in the navigation budget.
        ///</summary>
        [JsonProperty("remainingBudget")]
        public double RemainingBudget
        {
            get;
            set;
        }
        /// <summary>
        /// Total number of bytes stored as key-value pairs in origin's shared
        /// storage.
        ///</summary>
        [JsonProperty("bytesUsed")]
        public long BytesUsed
        {
            get;
            set;
        }
    }
}