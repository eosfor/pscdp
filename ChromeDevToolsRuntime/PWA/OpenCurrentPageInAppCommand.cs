namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Opens the current page in its web app identified by the manifest id, needs
    /// to be called on a page target. This function returns immediately without
    /// waiting for the app to finish loading.
    /// </summary>
    public sealed class OpenCurrentPageInAppCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PWA.openCurrentPageInApp";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the manifestId
        /// </summary>
        [JsonProperty("manifestId")]
        public string ManifestId
        {
            get;
            set;
        }
    }

    public sealed class OpenCurrentPageInAppCommandResponse : ICommandResponse<OpenCurrentPageInAppCommand>
    {
    }
}