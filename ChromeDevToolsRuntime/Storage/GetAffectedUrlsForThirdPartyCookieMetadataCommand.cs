namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the list of URLs from a page and its embedded resources that match
    /// existing grace period URL pattern rules.
    /// https://developers.google.com/privacy-sandbox/cookies/temporary-exceptions/grace-period
    /// </summary>
    public sealed class GetAffectedUrlsForThirdPartyCookieMetadataCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getAffectedUrlsForThirdPartyCookieMetadata";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The URL of the page currently being visited.
        /// </summary>
        [JsonProperty("firstPartyUrl")]
        public string FirstPartyUrl
        {
            get;
            set;
        }
        /// <summary>
        /// The list of embedded resource URLs from the page.
        /// </summary>
        [JsonProperty("thirdPartyUrls")]
        public string[] ThirdPartyUrls
        {
            get;
            set;
        }
    }

    public sealed class GetAffectedUrlsForThirdPartyCookieMetadataCommandResponse : ICommandResponse<GetAffectedUrlsForThirdPartyCookieMetadataCommand>
    {
        /// <summary>
        /// Array of matching URLs. If there is a primary pattern match for the first-
        /// party URL, only the first-party URL is returned in the array.
        ///</summary>
        [JsonProperty("matchedUrls")]
        public string[] MatchedUrls
        {
            get;
            set;
        }
    }
}