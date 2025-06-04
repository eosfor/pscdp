namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SensorReading
    /// </summary>
    public sealed class SensorReading
    {
        /// <summary>
        /// single
        ///</summary>
        [JsonProperty("single", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SensorReadingSingle Single
        {
            get;
            set;
        }
        /// <summary>
        /// xyz
        ///</summary>
        [JsonProperty("xyz", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SensorReadingXYZ Xyz
        {
            get;
            set;
        }
        /// <summary>
        /// quaternion
        ///</summary>
        [JsonProperty("quaternion", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SensorReadingQuaternion Quaternion
        {
            get;
            set;
        }
    }
}