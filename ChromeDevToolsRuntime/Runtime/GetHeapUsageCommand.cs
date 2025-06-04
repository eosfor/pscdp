namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the JavaScript heap usage.
    /// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
    /// </summary>
    public sealed class GetHeapUsageCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.getHeapUsage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetHeapUsageCommandResponse : ICommandResponse<GetHeapUsageCommand>
    {
        /// <summary>
        /// Used JavaScript heap size in bytes.
        ///</summary>
        [JsonProperty("usedSize")]
        public double UsedSize
        {
            get;
            set;
        }
        /// <summary>
        /// Allocated JavaScript heap size in bytes.
        ///</summary>
        [JsonProperty("totalSize")]
        public double TotalSize
        {
            get;
            set;
        }
        /// <summary>
        /// Used size in bytes in the embedder's garbage-collected heap.
        ///</summary>
        [JsonProperty("embedderHeapUsedSize")]
        public double EmbedderHeapUsedSize
        {
            get;
            set;
        }
        /// <summary>
        /// Size in bytes of backing storage for array buffers and external strings.
        ///</summary>
        [JsonProperty("backingStorageSize")]
        public double BackingStorageSize
        {
            get;
            set;
        }
    }
}