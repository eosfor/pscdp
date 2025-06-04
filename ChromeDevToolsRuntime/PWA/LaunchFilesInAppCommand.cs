namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Opens one or more local files from an installed web app identified by its
    /// manifestId. The web app needs to have file handlers registered to process
    /// the files. The API returns one or more page Target.TargetIDs which can be
    /// used to attach to via Target.attachToTarget or similar APIs.
    /// If some files in the parameters cannot be handled by the web app, they will
    /// be ignored. If none of the files can be handled, this API returns an error.
    /// If no files are provided as the parameter, this API also returns an error.
    /// 
    /// According to the definition of the file handlers in the manifest file, one
    /// Target.TargetID may represent a page handling one or more files. The order
    /// of the returned Target.TargetIDs is not guaranteed.
    /// 
    /// TODO(crbug.com/339454034): Check the existences of the input files.
    /// </summary>
    public sealed class LaunchFilesInAppCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PWA.launchFilesInApp";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the manifestId
        /// </summary>
        [JsonProperty("manifestId")]
        public string ManifestId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the files
        /// </summary>
        [JsonProperty("files")]
        public string[] Files
        {
            get;
            set;
        }
    }

    public sealed class LaunchFilesInAppCommandResponse : ICommandResponse<LaunchFilesInAppCommand>
    {
        /// <summary>
        /// IDs of the tab targets created as the result.
        ///</summary>
        [JsonProperty("targetIds")]
        public string[] TargetIds
        {
            get;
            set;
        }
    }
}