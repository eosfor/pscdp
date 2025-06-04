namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the effective Related Website Sets in use by this profile for the browser
    /// session. The effective Related Website Sets will not change during a browser session.
    /// </summary>
    public sealed class GetRelatedWebsiteSetsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.getRelatedWebsiteSets";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class GetRelatedWebsiteSetsCommandResponse : ICommandResponse<GetRelatedWebsiteSetsCommand>
    {
        /// <summary>
        /// Gets or sets the sets
        /// </summary>
        [JsonProperty("sets")]
        public RelatedWebsiteSet[] Sets
        {
            get;
            set;
        }
    }
}