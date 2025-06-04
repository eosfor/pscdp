namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// A filter used by target query/discovery/auto-attach operations.
    /// </summary>
    public sealed class FilterEntry
    {
        /// <summary>
        /// If set, causes exclusion of matching targets from the list.
        ///</summary>
        [JsonProperty("exclude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Exclude
        {
            get;
            set;
        }
        /// <summary>
        /// If not present, matches any type.
        ///</summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }
    }
}