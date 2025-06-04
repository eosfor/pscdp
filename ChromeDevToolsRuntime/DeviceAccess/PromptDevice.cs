namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// Device information displayed in a user prompt to select a device.
    /// </summary>
    public sealed class PromptDevice
    {
        /// <summary>
        /// id
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Display name as it appears in a device request user prompt.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}