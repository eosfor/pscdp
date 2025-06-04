namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable/disable prerendering manually.
    /// 
    /// This command is a short-term solution for https://crbug.com/1440085.
    /// See https://docs.google.com/document/d/12HVmFxYj5Jc-eJr5OmWsa2bqTJsbgGLKI6ZIyx0_wpA
    /// for more details.
    /// 
    /// TODO(https://crbug.com/1440085): Remove this once Puppeteer supports tab targets.
    /// </summary>
    public sealed class SetPrerenderingAllowedCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setPrerenderingAllowed";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the isAllowed
        /// </summary>
        [JsonProperty("isAllowed")]
        public bool IsAllowed
        {
            get;
            set;
        }
    }

    public sealed class SetPrerenderingAllowedCommandResponse : ICommandResponse<SetPrerenderingAllowedCommand>
    {
    }
}