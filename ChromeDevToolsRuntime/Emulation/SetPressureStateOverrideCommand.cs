namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: OBSOLETE: To remove when setPressureDataOverride is merged.
    /// Provides a given pressure state that will be processed and eventually be
    /// delivered to PressureObserver users. |source| must have been previously
    /// overridden by setPressureSourceOverrideEnabled.
    /// </summary>
    public sealed class SetPressureStateOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setPressureStateOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the source
        /// </summary>
        [JsonProperty("source")]
        public PressureSource Source
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the state
        /// </summary>
        [JsonProperty("state")]
        public PressureState State
        {
            get;
            set;
        }
    }

    public sealed class SetPressureStateOverrideCommandResponse : ICommandResponse<SetPressureStateOverrideCommand>
    {
    }
}