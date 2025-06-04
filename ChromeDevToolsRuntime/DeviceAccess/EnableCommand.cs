namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable events in this domain.
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceAccess.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}