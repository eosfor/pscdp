namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// SharedDictionaryIssueDetails
    /// </summary>
    public sealed class SharedDictionaryIssueDetails
    {
        /// <summary>
        /// sharedDictionaryError
        ///</summary>
        [JsonProperty("sharedDictionaryError")]
        public SharedDictionaryError SharedDictionaryError
        {
            get;
            set;
        }
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request")]
        public AffectedRequest Request
        {
            get;
            set;
        }
    }
}