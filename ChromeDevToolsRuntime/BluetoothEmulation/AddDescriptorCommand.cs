namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Adds a descriptor with |descriptorUuid| to the characteristic respresented
    /// by |characteristicId|.
    /// </summary>
    public sealed class AddDescriptorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.addDescriptor";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the characteristicId
        /// </summary>
        [JsonProperty("characteristicId")]
        public string CharacteristicId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the descriptorUuid
        /// </summary>
        [JsonProperty("descriptorUuid")]
        public string DescriptorUuid
        {
            get;
            set;
        }
    }

    public sealed class AddDescriptorCommandResponse : ICommandResponse<AddDescriptorCommand>
    {
        /// <summary>
        /// An identifier that uniquely represents this descriptor.
        ///</summary>
        [JsonProperty("descriptorId")]
        public string DescriptorId
        {
            get;
            set;
        }
    }
}