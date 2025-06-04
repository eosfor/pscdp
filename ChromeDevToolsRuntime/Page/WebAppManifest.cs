namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// WebAppManifest
    /// </summary>
    public sealed class WebAppManifest
    {
        /// <summary>
        /// backgroundColor
        ///</summary>
        [JsonProperty("backgroundColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BackgroundColor
        {
            get;
            set;
        }
        /// <summary>
        /// The extra description provided by the manifest.
        ///</summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }
        /// <summary>
        /// dir
        ///</summary>
        [JsonProperty("dir", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Dir
        {
            get;
            set;
        }
        /// <summary>
        /// display
        ///</summary>
        [JsonProperty("display", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Display
        {
            get;
            set;
        }
        /// <summary>
        /// The overrided display mode controlled by the user.
        ///</summary>
        [JsonProperty("displayOverrides", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] DisplayOverrides
        {
            get;
            set;
        }
        /// <summary>
        /// The handlers to open files.
        ///</summary>
        [JsonProperty("fileHandlers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FileHandler[] FileHandlers
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
        /// id
        ///</summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// lang
        ///</summary>
        [JsonProperty("lang", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Lang
        {
            get;
            set;
        }
        /// <summary>
        /// TODO(crbug.com/1231886): This field is non-standard and part of a Chrome
        /// experiment. See:
        /// https://github.com/WICG/web-app-launch/blob/main/launch_handler.md
        ///</summary>
        [JsonProperty("launchHandler", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LaunchHandler LaunchHandler
        {
            get;
            set;
        }
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
        /// orientation
        ///</summary>
        [JsonProperty("orientation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Orientation
        {
            get;
            set;
        }
        /// <summary>
        /// preferRelatedApplications
        ///</summary>
        [JsonProperty("preferRelatedApplications", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? PreferRelatedApplications
        {
            get;
            set;
        }
        /// <summary>
        /// The handlers to open protocols.
        ///</summary>
        [JsonProperty("protocolHandlers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ProtocolHandler[] ProtocolHandlers
        {
            get;
            set;
        }
        /// <summary>
        /// relatedApplications
        ///</summary>
        [JsonProperty("relatedApplications", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RelatedApplication[] RelatedApplications
        {
            get;
            set;
        }
        /// <summary>
        /// scope
        ///</summary>
        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Scope
        {
            get;
            set;
        }
        /// <summary>
        /// Non-standard, see
        /// https://github.com/WICG/manifest-incubations/blob/gh-pages/scope_extensions-explainer.md
        ///</summary>
        [JsonProperty("scopeExtensions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ScopeExtension[] ScopeExtensions
        {
            get;
            set;
        }
        /// <summary>
        /// The screenshots used by chromium.
        ///</summary>
        [JsonProperty("screenshots", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Screenshot[] Screenshots
        {
            get;
            set;
        }
        /// <summary>
        /// shareTarget
        ///</summary>
        [JsonProperty("shareTarget", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShareTarget ShareTarget
        {
            get;
            set;
        }
        /// <summary>
        /// shortName
        ///</summary>
        [JsonProperty("shortName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShortName
        {
            get;
            set;
        }
        /// <summary>
        /// shortcuts
        ///</summary>
        [JsonProperty("shortcuts", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Shortcut[] Shortcuts
        {
            get;
            set;
        }
        /// <summary>
        /// startUrl
        ///</summary>
        [JsonProperty("startUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StartUrl
        {
            get;
            set;
        }
        /// <summary>
        /// themeColor
        ///</summary>
        [JsonProperty("themeColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThemeColor
        {
            get;
            set;
        }
    }
}