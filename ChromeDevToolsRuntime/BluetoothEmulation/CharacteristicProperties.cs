namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Describes the properties of a characteristic. This follows Bluetooth Core
    /// Specification BT 4.2 Vol 3 Part G 3.3.1. Characteristic Properties.
    /// </summary>
    public sealed class CharacteristicProperties
    {
        /// <summary>
        /// broadcast
        ///</summary>
        [JsonProperty("broadcast", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Broadcast
        {
            get;
            set;
        }
        /// <summary>
        /// read
        ///</summary>
        [JsonProperty("read", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Read
        {
            get;
            set;
        }
        /// <summary>
        /// writeWithoutResponse
        ///</summary>
        [JsonProperty("writeWithoutResponse", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? WriteWithoutResponse
        {
            get;
            set;
        }
        /// <summary>
        /// write
        ///</summary>
        [JsonProperty("write", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Write
        {
            get;
            set;
        }
        /// <summary>
        /// notify
        ///</summary>
        [JsonProperty("notify", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Notify
        {
            get;
            set;
        }
        /// <summary>
        /// indicate
        ///</summary>
        [JsonProperty("indicate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Indicate
        {
            get;
            set;
        }
        /// <summary>
        /// authenticatedSignedWrites
        ///</summary>
        [JsonProperty("authenticatedSignedWrites", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AuthenticatedSignedWrites
        {
            get;
            set;
        }
        /// <summary>
        /// extendedProperties
        ///</summary>
        [JsonProperty("extendedProperties", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ExtendedProperties
        {
            get;
            set;
        }
    }
}