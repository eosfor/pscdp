namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Set the state of the simulated central.
    /// </summary>
    public sealed class SetSimulatedCentralStateCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.setSimulatedCentralState";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// State of the simulated central.
        /// </summary>
        [JsonProperty("state")]
        public CentralState State
        {
            get;
            set;
        }
    }

    public sealed class SetSimulatedCentralStateCommandResponse : ICommandResponse<SetSimulatedCentralStateCommand>
    {
    }
}