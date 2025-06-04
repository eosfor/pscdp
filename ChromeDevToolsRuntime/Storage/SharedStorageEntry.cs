namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Struct for a single key-value pair in an origin's shared storage.
    /// </summary>
    public sealed class SharedStorageEntry
    {
        /// <summary>
        /// key
        ///</summary>
        [JsonProperty("key")]
        public string Key
        {
            get;
            set;
        }
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    }
}