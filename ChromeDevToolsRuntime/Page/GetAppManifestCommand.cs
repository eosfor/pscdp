namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets the processed manifest for this current document.
    ///   This API always waits for the manifest to be loaded.
    ///   If manifestId is provided, and it does not match the manifest of the
    ///     current document, this API errors out.
    ///   If there is not a loaded page, this API errors out immediately.
    /// </summary>
    public sealed class GetAppManifestCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getAppManifest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the manifestId
        /// </summary>
        [JsonProperty("manifestId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ManifestId
        {
            get;
            set;
        }
    }

    public sealed class GetAppManifestCommandResponse : ICommandResponse<GetAppManifestCommand>
    {
        /// <summary>
        /// Manifest location.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the errors
        /// </summary>
        [JsonProperty("errors")]
        public AppManifestError[] Errors
        {
            get;
            set;
        }
        /// <summary>
        /// Manifest content.
        ///</summary>
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Data
        {
            get;
            set;
        }
        /// <summary>
        /// Parsed manifest properties. Deprecated, use manifest instead.
        ///</summary>
        [JsonProperty("parsed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AppManifestParsedProperties Parsed
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the manifest
        /// </summary>
        [JsonProperty("manifest")]
        public WebAppManifest Manifest
        {
            get;
            set;
        }
    }
}