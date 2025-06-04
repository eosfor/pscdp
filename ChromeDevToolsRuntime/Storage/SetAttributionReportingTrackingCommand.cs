namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables/disables issuing of Attribution Reporting events.
    /// </summary>
    public sealed class SetAttributionReportingTrackingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setAttributionReportingTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the enable
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable
        {
            get;
            set;
        }
    }

    public sealed class SetAttributionReportingTrackingCommandResponse : ICommandResponse<SetAttributionReportingTrackingCommand>
    {
    }
}