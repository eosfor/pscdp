namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable the BluetoothEmulation domain.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "BluetoothEmulation.enable";
        
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
        /// <summary>
        /// If the simulated central supports low-energy.
        /// </summary>
        [JsonProperty("leSupported")]
        public bool LeSupported
        {
            get;
            set;
        }
    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}