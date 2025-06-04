namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes the Storage Bucket with the given storage key and bucket name.
    /// </summary>
    public sealed class DeleteStorageBucketCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.deleteStorageBucket";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the bucket
        /// </summary>
        [JsonProperty("bucket")]
        public StorageBucket Bucket
        {
            get;
            set;
        }
    }

    public sealed class DeleteStorageBucketCommandResponse : ICommandResponse<DeleteStorageBucketCommand>
    {
    }
}