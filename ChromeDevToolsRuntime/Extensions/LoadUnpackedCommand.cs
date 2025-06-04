namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;

    /// <summary>
    /// Installs an unpacked extension from the filesystem similar to
    /// --load-extension CLI flags. Returns extension ID once the extension
    /// has been installed. Available if the client is connected using the
    /// --remote-debugging-pipe flag and the --enable-unsafe-extension-debugging
    /// flag is set.
    /// </summary>
    public sealed class LoadUnpackedCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Extensions.loadUnpacked";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Absolute file path.
        /// </summary>
        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
    }

    public sealed class LoadUnpackedCommandResponse : ICommandResponse<LoadUnpackedCommand>
    {
        /// <summary>
        /// Extension id.
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    }
}