namespace BaristaLabs.ChromeDevTools.Runtime.FileSystem
{
    using Newtonsoft.Json;

    /// <summary>
    /// Directory
    /// </summary>
    public sealed class Directory
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
        /// nestedDirectories
        ///</summary>
        [JsonProperty("nestedDirectories")]
        public string[] NestedDirectories
        {
            get;
            set;
        }
        /// <summary>
        /// Files that are directly nested under this directory.
        ///</summary>
        [JsonProperty("nestedFiles")]
        public File[] NestedFiles
        {
            get;
            set;
        }
    }
}