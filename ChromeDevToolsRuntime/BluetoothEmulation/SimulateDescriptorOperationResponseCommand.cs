namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulates the response from the descriptor with |descriptorId| for a
    /// descriptor operation of |type|. The |code| value follows the Error
    /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
    /// The |data| is expected to exist when simulating a successful read operation
    /// response.
    /// </summary>
    public sealed class SimulateDescriptorOperationResponseCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.simulateDescriptorOperationResponse";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the descriptorId
        /// </summary>
        [JsonProperty("descriptorId")]
        public string DescriptorId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public DescriptorOperationType Type
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
        /// <summary>
        /// Gets or sets the data
        /// </summary>
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] Data
        {
            get;
            set;
        }
    }

    public sealed class SimulateDescriptorOperationResponseCommandResponse : ICommandResponse<SimulateDescriptorOperationResponseCommand>
    {
    }
}