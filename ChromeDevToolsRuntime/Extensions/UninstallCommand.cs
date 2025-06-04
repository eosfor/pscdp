namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Uninstalls an unpacked extension (others not supported) from the profile.
    /// Available if the client is connected using the --remote-debugging-pipe flag
    /// and the --enable-unsafe-extension-debugging.
    /// </summary>
    public sealed class UninstallCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Extensions.uninstall";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Extension id.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }

    public sealed class UninstallCommandResponse : ICommandResponse<UninstallCommand>
    {
    }
}