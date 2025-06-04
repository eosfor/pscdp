namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the Geolocation Position or Error. Omitting latitude, longitude or
    /// accuracy emulates position unavailable.
    /// </summary>
    public sealed class SetGeolocationOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setGeolocationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Mock latitude
        /// </summary>
        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Latitude
        {
            get;
            set;
        }
        /// <summary>
        /// Mock longitude
        /// </summary>
        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Longitude
        {
            get;
            set;
        }
        /// <summary>
        /// Mock accuracy
        /// </summary>
        [JsonProperty("accuracy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Accuracy
        {
            get;
            set;
        }
        /// <summary>
        /// Mock altitude
        /// </summary>
        [JsonProperty("altitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Altitude
        {
            get;
            set;
        }
        /// <summary>
        /// Mock altitudeAccuracy
        /// </summary>
        [JsonProperty("altitudeAccuracy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? AltitudeAccuracy
        {
            get;
            set;
        }
        /// <summary>
        /// Mock heading
        /// </summary>
        [JsonProperty("heading", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Heading
        {
            get;
            set;
        }
        /// <summary>
        /// Mock speed
        /// </summary>
        [JsonProperty("speed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Speed
        {
            get;
            set;
        }
    }

    public sealed class SetGeolocationOverrideCommandResponse : ICommandResponse<SetGeolocationOverrideCommand>
    {
    }
}