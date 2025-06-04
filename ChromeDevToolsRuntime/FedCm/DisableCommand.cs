namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disable
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FedCm.disable";
        
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