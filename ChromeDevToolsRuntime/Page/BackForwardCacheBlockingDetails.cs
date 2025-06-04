namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// BackForwardCacheBlockingDetails
    /// </summary>
    public sealed class BackForwardCacheBlockingDetails
    {
        /// <summary>
        /// Url of the file where blockage happened. Optional because of tests.
        ///</summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Function name where blockage happened. Optional because of anonymous functions and tests.
        ///</summary>
        [JsonProperty("function", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Function
        {
            get;
            set;
        }
        /// <summary>
        /// Line number in the script (0-based).
        ///</summary>
        [JsonProperty("lineNumber")]
        public long LineNumber
        {
            get;
            set;
        }
        /// <summary>
        /// Column number in the script (0-based).
        ///</summary>
        [JsonProperty("columnNumber")]
        public long ColumnNumber
        {
            get;
            set;
        }
    }
}