namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for when a characteristic operation of |type| to the characteristic
    /// respresented by |characteristicId| happened. |data| and |writeType| is
    /// expected to exist when |type| is write.
    /// </summary>
    public sealed class CharacteristicOperationReceivedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the characteristicId
        /// </summary>
        [JsonProperty("characteristicId")]
        public string CharacteristicId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public CharacteristicOperationType Type
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
        /// <summary>
        /// Gets or sets the writeType
        /// </summary>
        [JsonProperty("writeType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CharacteristicWriteType? WriteType
        {
            get;
            set;
        }
    }
}