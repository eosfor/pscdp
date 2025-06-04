namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable events in this domain.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceAccess.disable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class DisableCommandResponse : ICommandResponse<DisableCommand>
    {
    }
}