namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// DevicePosture
    /// </summary>
    public sealed class DevicePosture
    {
        /// <summary>
        /// Current posture of the device
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}