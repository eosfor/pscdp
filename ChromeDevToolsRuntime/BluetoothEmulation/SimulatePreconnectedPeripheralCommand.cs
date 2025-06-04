namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulates a peripheral with |address|, |name| and |knownServiceUuids|
    /// that has already been connected to the system.
    /// </summary>
    public sealed class SimulatePreconnectedPeripheralCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.simulatePreconnectedPeripheral";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

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
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the manufacturerData
        /// </summary>
        [JsonProperty("manufacturerData")]
        public ManufacturerData[] ManufacturerData
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the knownServiceUuids
        /// </summary>
        [JsonProperty("knownServiceUuids")]
        public string[] KnownServiceUuids
        {
            get;
            set;
        }
    }

    public sealed class SimulatePreconnectedPeripheralCommandResponse : ICommandResponse<SimulatePreconnectedPeripheralCommand>
    {
    }
}