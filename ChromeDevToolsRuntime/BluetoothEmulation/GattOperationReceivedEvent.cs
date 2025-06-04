namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for when a GATT operation of |type| to the peripheral with |address|
    /// happened.
    /// </summary>
    public sealed class GattOperationReceivedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the address
        /// </summary>
        [JsonProperty("address")]
        public string Address
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public GATTOperationType Type
        {
            get;
            set;
        }
    }
}