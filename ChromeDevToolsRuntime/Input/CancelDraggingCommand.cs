namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cancels any active dragging in the page.
    /// </summary>
    public sealed class CancelDraggingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Input.cancelDragging";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class CancelDraggingCommandResponse : ICommandResponse<CancelDraggingCommand>
    {
    }
}