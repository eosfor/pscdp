namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulates a GATT disconnection from the peripheral with |address|.
    /// </summary>
    public sealed class SimulateGATTDisconnectionCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.simulateGATTDisconnection";
        
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
    }

    public sealed class SimulateGATTDisconnectionCommandResponse : ICommandResponse<SimulateGATTDisconnectionCommand>
    {
    }
}