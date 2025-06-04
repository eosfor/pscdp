namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stores the byte data of the advertisement packet sent by a Bluetooth device.
    /// </summary>
    public sealed class ScanRecord
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// uuids
        ///</summary>
        [JsonProperty("uuids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Uuids
        {
            get;
            set;
        }
        /// <summary>
        /// Stores the external appearance description of the device.
        ///</summary>
        [JsonProperty("appearance", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Appearance
        {
            get;
            set;
        }
        /// <summary>
        /// Stores the transmission power of a broadcasting device.
        ///</summary>
        [JsonProperty("txPower", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? TxPower
        {
            get;
            set;
        }
        /// <summary>
        /// Key is the company identifier and the value is an array of bytes of
        /// manufacturer specific data.
        ///</summary>
        [JsonProperty("manufacturerData", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ManufacturerData[] ManufacturerData
        {
            get;
            set;
        }
    }
}