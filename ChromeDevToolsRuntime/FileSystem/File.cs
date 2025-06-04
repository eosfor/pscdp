namespace BaristaLabs.ChromeDevTools.Runtime.FileSystem
{
    using Newtonsoft.Json;

    /// <summary>
    /// File
    /// </summary>
    public sealed class File
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Timestamp
        ///</summary>
        [JsonProperty("lastModified")]
        public double LastModified
        {
            get;
            set;
        }
        /// <summary>
        /// Size in bytes
        ///</summary>
        [JsonProperty("size")]
        public double Size
        {
            get;
            set;
        }
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}