namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables autofill domain notifications.
    /// </summary>
    public sealed class DisableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Autofill.disable";
        
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