namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides a pressure source of a given type, as used by the Compute
    /// Pressure API, so that updates to PressureObserver.observe() are provided
    /// via setPressureStateOverride instead of being retrieved from
    /// platform-provided telemetry data.
    /// </summary>
    public sealed class SetPressureSourceOverrideEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setPressureSourceOverrideEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
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
        /// Gets or sets the metadata
        /// </summary>
        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PressureMetadata Metadata
        {
            get;
            set;
        }
    }

    public sealed class SetPressureSourceOverrideEnabledCommandResponse : ICommandResponse<SetPressureSourceOverrideEnabledCommand>
    {
    }
}