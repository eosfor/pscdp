namespace BaristaLabs.ChromeDevTools.Runtime.FileSystem
{
    using Newtonsoft.Json;

    /// <summary>
    /// BucketFileSystemLocator
    /// </summary>
    public sealed class BucketFileSystemLocator
    {
        /// <summary>
        /// Storage key
        ///</summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
        /// <summary>
        /// Bucket name. Not passing a `bucketName` will retrieve the default Bucket. (https://developer.mozilla.org/en-US/docs/Web/API/Storage_API#storage_buckets)
        ///</summary>
        [JsonProperty("bucketName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BucketName
        {
            get;
            set;
        }
        /// <summary>
        /// Path to the directory using each path component as an array item.
        ///</summary>
        [JsonProperty("pathComponents")]
        public string[] PathComponents
        {
            get;
            set;
        }
    }
}