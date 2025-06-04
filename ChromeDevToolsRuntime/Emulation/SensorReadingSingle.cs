namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SensorReadingSingle
    /// </summary>
    public sealed class SensorReadingSingle
    {
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value")]
        public double Value
        {
            get;
            set;
        }
    }
}