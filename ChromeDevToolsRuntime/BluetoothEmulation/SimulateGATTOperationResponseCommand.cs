namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulates the response code from the peripheral with |address| for a
    /// GATT operation of |type|. The |code| value follows the HCI Error Codes from
    /// Bluetooth Core Specification Vol 2 Part D 1.3 List Of Error Codes.
    /// </summary>
    public sealed class SimulateGATTOperationResponseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.simulateGATTOperationResponse";
        
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
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public GATTOperationType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the code
        /// </summary>
        [JsonProperty("code")]
        public long Code
        {
            get;
            set;
        }
    }

    public sealed class SimulateGATTOperationResponseCommandResponse : ICommandResponse<SimulateGATTOperationResponseCommand>
    {
    }
}