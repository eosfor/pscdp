namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Adds a service with |serviceUuid| to the peripheral with |address|.
    /// </summary>
    public sealed class AddServiceCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.addService";
        
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
        /// Gets or sets the serviceUuid
        /// </summary>
        [JsonProperty("serviceUuid")]
        public string ServiceUuid
        {
            get;
            set;
        }
    }

    public sealed class AddServiceCommandResponse : ICommandResponse<AddServiceCommand>
    {
        /// <summary>
        /// An identifier that uniquely represents this service.
        ///</summary>
        [JsonProperty("serviceId")]
        public string ServiceId
        {
            get;
            set;
        }
    }
}