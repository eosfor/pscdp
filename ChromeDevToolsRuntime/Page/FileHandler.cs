namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// FileHandler
    /// </summary>
    public sealed class FileHandler
    {
        /// <summary>
        /// action
        ///</summary>
        [JsonProperty("action")]
        public string Action
        {
            get;
            set;
        }
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
        /// icons
        ///</summary>
        [JsonProperty("icons", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ImageResource[] Icons
        {
            get;
            set;
        }
        /// <summary>
        /// Mimic a map, name is the key, accepts is the value.
        ///</summary>
        [JsonProperty("accepts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FileFilter[] Accepts
        {
            get;
            set;
        }
        /// <summary>
        /// Won't repeat the enums, using string for easy comparison. Same as the
        /// other enums below.
        ///</summary>
        [JsonProperty("launchType")]
        public string LaunchType
        {
            get;
            set;
        }
    }
}