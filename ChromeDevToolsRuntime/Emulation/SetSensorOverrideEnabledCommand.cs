namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides a platform sensor of a given type. If |enabled| is true, calls to
    /// Sensor.start() will use a virtual sensor as backend rather than fetching
    /// data from a real hardware sensor. Otherwise, existing virtual
    /// sensor-backend Sensor objects will fire an error event and new calls to
    /// Sensor.start() will attempt to use a real sensor instead.
    /// </summary>
    public sealed class SetSensorOverrideEnabledCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setSensorOverrideEnabled";
        
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
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public SensorType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the metadata
        /// </summary>
        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SensorMetadata Metadata
        {
            get;
            set;
        }
    }

    public sealed class SetSensorOverrideEnabledCommandResponse : ICommandResponse<SetSensorOverrideEnabledCommand>
    {
    }
}