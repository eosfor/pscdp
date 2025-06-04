namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// FileFilter
    /// </summary>
    public sealed class FileFilter
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// accepts
        ///</summary>
        [JsonProperty("accepts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Accepts
        {
            get;
            set;
        }
    }
}