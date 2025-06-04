namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SensorReadingQuaternion
    /// </summary>
    public sealed class SensorReadingQuaternion
    {
        /// <summary>
        /// x
        ///</summary>
        [JsonProperty("x")]
        public double X
        {
            get;
            set;
        }
        /// <summary>
        /// y
        ///</summary>
        [JsonProperty("y")]
        public double Y
        {
            get;
            set;
        }
        /// <summary>
        /// z
        ///</summary>
        [JsonProperty("z")]
        public double Z
        {
            get;
            set;
        }
        /// <summary>
        /// w
        ///</summary>
        [JsonProperty("w")]
        public double W
        {
            get;
            set;
        }
    }
}