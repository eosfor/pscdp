namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Reloads given page optionally ignoring the cache.
    /// </summary>
    public sealed class ReloadCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.reload";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If true, browser cache is ignored (as if the user pressed Shift+refresh).
        /// </summary>
        [JsonProperty("ignoreCache", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IgnoreCache
        {
            get;
            set;
        }
        /// <summary>
        /// If set, the script will be injected into all frames of the inspected page after reload.
        /// Argument will be ignored if reloading dataURL origin.
        /// </summary>
        [JsonProperty("scriptToEvaluateOnLoad", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScriptToEvaluateOnLoad
        {
            get;
            set;
        }
        /// <summary>
        /// If set, an error will be thrown if the target page's main frame's
        /// loader id does not match the provided id. This prevents accidentally
        /// reloading an unintended target in case there's a racing navigation.
        /// </summary>
        [JsonProperty("loaderId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LoaderId
        {
            get;
            set;
        }
    }

    public sealed class ReloadCommandResponse : ICommandResponse<ReloadCommand>
    {
    }
}