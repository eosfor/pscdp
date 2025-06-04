namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// GetOverriddenSensorInformation
    /// </summary>
    public sealed class GetOverriddenSensorInformationCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.getOverriddenSensorInformation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public SensorType Type
        {
            get;
            set;
        }
    }

    public sealed class GetOverriddenSensorInformationCommandResponse : ICommandResponse<GetOverriddenSensorInformationCommand>
    {
        /// <summary>
        /// Gets or sets the requestedSamplingFrequency
        /// </summary>
        [JsonProperty("requestedSamplingFrequency")]
        public double RequestedSamplingFrequency
        {
            get;
            set;
        }
    }
}