namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for when a descriptor operation of |type| to the descriptor
    /// respresented by |descriptorId| happened. |data| is expected to exist when
    /// |type| is write.
    /// </summary>
    public sealed class DescriptorOperationReceivedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the descriptorId
        /// </summary>
        [JsonProperty("descriptorId")]
        public string DescriptorId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public DescriptorOperationType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the data
        /// </summary>
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] Data
        {
            get;
            set;
        }
    }
}