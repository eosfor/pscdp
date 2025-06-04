namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the display features override set with either setDeviceMetricsOverride()
    /// or setDisplayFeaturesOverride() and starts using display features from the
    /// platform again.
    /// Does nothing if no override is set.
    /// </summary>
    public sealed class ClearDisplayFeaturesOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.clearDisplayFeaturesOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearDisplayFeaturesOverrideCommandResponse : ICommandResponse<ClearDisplayFeaturesOverrideCommand>
    {
    }
}