namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stores the manufacturer data
    /// </summary>
    public sealed class ManufacturerData
    {
        /// <summary>
        /// Company identifier
        /// https://bitbucket.org/bluetooth-SIG/public/src/main/assigned_numbers/company_identifiers/company_identifiers.yaml
        /// https://usb.org/developers
        ///</summary>
        [JsonProperty("key")]
        public long Key
        {
            get;
            set;
        }
        /// <summary>
        /// Manufacturer-specific data
        ///</summary>
        [JsonProperty("data")]
        public byte[] Data
        {
            get;
            set;
        }
    }
}