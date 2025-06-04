namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulates an advertisement packet described in |entry| being received by
    /// the central.
    /// </summary>
    public sealed class SimulateAdvertisementCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.simulateAdvertisement";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the entry
        /// </summary>
        [JsonProperty("entry")]
        public ScanEntry Entry
        {
            get;
            set;
        }
    }

    public sealed class SimulateAdvertisementCommandResponse : ICommandResponse<SimulateAdvertisementCommand>
    {
    }
}