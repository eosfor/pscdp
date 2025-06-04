namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Provides a given pressure data set that will be processed and eventually be
    /// delivered to PressureObserver users. |source| must have been previously
    /// overridden by setPressureSourceOverrideEnabled.
    /// </summary>
    public sealed class SetPressureDataOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setPressureDataOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the source
        /// </summary>
        [JsonProperty("source")]
        public PressureSource Source
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the state
        /// </summary>
        [JsonProperty("state")]
        public PressureState State
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the ownContributionEstimate
        /// </summary>
        [JsonProperty("ownContributionEstimate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? OwnContributionEstimate
        {
            get;
            set;
        }
    }

    public sealed class SetPressureDataOverrideCommandResponse : ICommandResponse<SetPressureDataOverrideCommand>
    {
    }
}