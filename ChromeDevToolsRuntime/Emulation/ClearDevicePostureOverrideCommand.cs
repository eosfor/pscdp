namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears a device posture override set with either setDeviceMetricsOverride()
    /// or setDevicePostureOverride() and starts using posture information from the
    /// platform again.
    /// Does nothing if no override is set.
    /// </summary>
    public sealed class ClearDevicePostureOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.clearDevicePostureOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class ClearDevicePostureOverrideCommandResponse : ICommandResponse<ClearDevicePostureOverrideCommand>
    {
    }
}