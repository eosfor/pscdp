namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// A device request opened a user prompt to select a device. Respond with the
    /// selectPrompt or cancelPrompt command.
    /// </summary>
    public sealed class DeviceRequestPromptedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the devices
        /// </summary>
        [JsonProperty("devices")]
        public PromptDevice[] Devices
        {
            get;
            set;
        }
    }
}