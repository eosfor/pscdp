namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Creates a new page.
    /// </summary>
    public sealed class CreateTargetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Target.createTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// The initial URL the page will be navigated to. An empty string indicates about:blank.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Frame left origin in DIP (requires newWindow to be true or headless shell).
        /// </summary>
        [JsonProperty("left", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Left
        {
            get;
            set;
        }
        /// <summary>
        /// Frame top origin in DIP (requires newWindow to be true or headless shell).
        /// </summary>
        [JsonProperty("top", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Top
        {
            get;
            set;
        }
        /// <summary>
        /// Frame width in DIP (requires newWindow to be true or headless shell).
        /// </summary>
        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Width
        {
            get;
            set;
        }
        /// <summary>
        /// Frame height in DIP (requires newWindow to be true or headless shell).
        /// </summary>
        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Height
        {
            get;
            set;
        }
        /// <summary>
        /// Frame window state (requires newWindow to be true or headless shell).
        /// Default is normal.
        /// </summary>
        [JsonProperty("windowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public WindowState? WindowState
        {
            get;
            set;
        }
        /// <summary>
        /// The browser context to create the page in.
        /// </summary>
        [JsonProperty("browserContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BrowserContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Whether BeginFrames for this target will be controlled via DevTools (headless shell only,
        /// not supported on MacOS yet, false by default).
        /// </summary>
        [JsonProperty("enableBeginFrameControl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? EnableBeginFrameControl
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to create a new Window or Tab (false by default, not supported by headless shell).
        /// </summary>
        [JsonProperty("newWindow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NewWindow
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to create the target in background or foreground (false by default, not supported
        /// by headless shell).
        /// </summary>
        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Background
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to create the target of type "tab".
        /// </summary>
        [JsonProperty("forTab", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ForTab
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to create a hidden target. The hidden target is observable via protocol, but not
        /// present in the tab UI strip. Cannot be created with `forTab: true`, `newWindow: true` or
        /// `background: false`. The life-time of the tab is limited to the life-time of the session.
        /// </summary>
        [JsonProperty("hidden", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Hidden
        {
            get;
            set;
        }
    }

    public sealed class CreateTargetCommandResponse : ICommandResponse<CreateTargetCommand>
    {
        /// <summary>
        /// The id of the page opened.
        ///</summary>
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    }
}