namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes the characteristic respresented by |characteristicId| from the
    /// simulated central.
    /// </summary>
    public sealed class RemoveCharacteristicCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.removeCharacteristic";
        
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
    }

    public sealed class RemoveCharacteristicCommandResponse : ICommandResponse<RemoveCharacteristicCommand>
    {
    }
}