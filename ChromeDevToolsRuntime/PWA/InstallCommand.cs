namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Installs the given manifest identity, optionally using the given install_url
    /// or IWA bundle location.
    /// 
    /// TODO(crbug.com/337872319) Support IWA to meet the following specific
    /// requirement.
    /// IWA-specific install description: If the manifest_id is isolated-app://,
    /// install_url_or_bundle_url is required, and can be either an http(s) URL or
    /// file:// URL pointing to a signed web bundle (.swbn). The .swbn file's
    /// signing key must correspond to manifest_id. If Chrome is not in IWA dev
    /// mode, the installation will fail, regardless of the state of the allowlist.
    /// </summary>
    public sealed class InstallCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PWA.install";
        
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
        /// <summary>
        /// The location of the app or bundle overriding the one derived from the
        /// manifestId.
        /// </summary>
        [JsonProperty("installUrlOrBundleUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InstallUrlOrBundleUrl
        {
            get;
            set;
        }
    }

    public sealed class InstallCommandResponse : ICommandResponse<InstallCommand>
    {
    }
}