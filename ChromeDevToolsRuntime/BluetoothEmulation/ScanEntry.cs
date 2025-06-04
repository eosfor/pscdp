namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stores the advertisement packet information that is sent by a Bluetooth device.
    /// </summary>
    public sealed class ScanEntry
    {
        /// <summary>
        /// deviceAddress
        ///</summary>
        [JsonProperty("deviceAddress")]
        public string DeviceAddress
        {
            get;
            set;
        }
        /// <summary>
        /// rssi
        ///</summary>
        [JsonProperty("rssi")]
        public long Rssi
        {
            get;
            set;
        }
        /// <summary>
        /// scanRecord
        ///</summary>
        [JsonProperty("scanRecord")]
        public ScanRecord ScanRecord
        {
            get;
            set;
        }
    }
}