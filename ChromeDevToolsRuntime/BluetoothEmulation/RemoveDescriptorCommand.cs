namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes the descriptor with |descriptorId| from the simulated central.
    /// </summary>
    public sealed class RemoveDescriptorCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.removeDescriptor";
        
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
    }

    public sealed class RemoveDescriptorCommandResponse : ICommandResponse<RemoveDescriptorCommand>
    {
    }
}