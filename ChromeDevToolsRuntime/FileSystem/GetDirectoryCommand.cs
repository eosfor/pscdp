namespace BaristaLabs.ChromeDevTools.Runtime.FileSystem
{
    using Newtonsoft.Json;

    /// <summary>
    /// GetDirectory
    /// </summary>
    public sealed class GetDirectoryCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "FileSystem.getDirectory";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the bucketFileSystemLocator
        /// </summary>
        [JsonProperty("bucketFileSystemLocator")]
        public BucketFileSystemLocator BucketFileSystemLocator
        {
            get;
            set;
        }
    }

    public sealed class GetDirectoryCommandResponse : ICommandResponse<GetDirectoryCommand>
    {
        /// <summary>
        /// Returns the directory object at the path.
        ///</summary>
        [JsonProperty("directory")]
        public Directory Directory
        {
            get;
            set;
        }
    }
}