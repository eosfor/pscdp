namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// StorageBucket
    /// </summary>
    public sealed class StorageBucket
    {
        /// <summary>
        /// storageKey
        ///</summary>
        [JsonProperty("storageKey")]
        public string StorageKey
        {
            get;
            set;
        }
        /// <summary>
        /// If not specified, it is the default bucket of the storageKey.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
    }
}