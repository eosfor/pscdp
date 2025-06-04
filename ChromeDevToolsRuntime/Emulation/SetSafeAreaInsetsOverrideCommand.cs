namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the values for env(safe-area-inset-*) and env(safe-area-max-inset-*). Unset values will cause the
    /// respective variables to be undefined, even if previously overridden.
    /// </summary>
    public sealed class SetSafeAreaInsetsOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setSafeAreaInsetsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the insets
        /// </summary>
        [JsonProperty("insets")]
        public SafeAreaInsets Insets
        {
            get;
            set;
        }
    }

    public sealed class SetSafeAreaInsetsOverrideCommandResponse : ICommandResponse<SetSafeAreaInsetsOverrideCommand>
    {
    }
}