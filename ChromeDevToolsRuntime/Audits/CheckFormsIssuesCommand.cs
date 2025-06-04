namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// Runs the form issues check for the target page. Found issues are reported
    /// using Audits.issueAdded event.
    /// </summary>
    public sealed class CheckFormsIssuesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Audits.checkFormsIssues";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CheckFormsIssuesCommandResponse : ICommandResponse<CheckFormsIssuesCommand>
    {
        /// <summary>
        /// Gets or sets the formIssues
        /// </summary>
        [JsonProperty("formIssues")]
        public GenericIssueDetails[] FormIssues
        {
            get;
            set;
        }
    }
}