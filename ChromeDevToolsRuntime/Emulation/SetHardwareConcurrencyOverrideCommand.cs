namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetHardwareConcurrencyOverride
    /// </summary>
    public sealed class SetHardwareConcurrencyOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setHardwareConcurrencyOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Hardware concurrency to report
        /// </summary>
        [JsonProperty("hardwareConcurrency")]
        public long HardwareConcurrency
        {
            get;
            set;
        }
    }

    public sealed class SetHardwareConcurrencyOverrideCommandResponse : ICommandResponse<SetHardwareConcurrencyOverrideCommand>
    {
    }
}