namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// https://wicg.github.io/attribution-reporting-api/
    /// </summary>
    public sealed class SetAttributionReportingLocalTestingModeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setAttributionReportingLocalTestingMode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// If enabled, noise is suppressed and reports are sent immediately.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    }

    public sealed class SetAttributionReportingLocalTestingModeCommandResponse : ICommandResponse<SetAttributionReportingLocalTestingModeCommand>
    {
    }
}