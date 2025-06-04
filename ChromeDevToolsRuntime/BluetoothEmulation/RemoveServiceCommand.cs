namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes the service respresented by |serviceId| from the simulated central.
    /// </summary>
    public sealed class RemoveServiceCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.removeService";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the serviceId
        /// </summary>
        [JsonProperty("serviceId")]
        public string ServiceId
        {
            get;
            set;
        }
    }

    public sealed class RemoveServiceCommandResponse : ICommandResponse<RemoveServiceCommand>
    {
    }
}