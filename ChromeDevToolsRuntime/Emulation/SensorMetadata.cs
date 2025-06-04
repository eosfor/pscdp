namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SensorMetadata
    /// </summary>
    public sealed class SensorMetadata
    {
        /// <summary>
        /// available
        ///</summary>
        [JsonProperty("available", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Available
        {
            get;
            set;
        }
        /// <summary>
        /// minimumFrequency
        ///</summary>
        [JsonProperty("minimumFrequency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MinimumFrequency
        {
            get;
            set;
        }
        /// <summary>
        /// maximumFrequency
        ///</summary>
        [JsonProperty("maximumFrequency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? MaximumFrequency
        {
            get;
            set;
        }
    }
}