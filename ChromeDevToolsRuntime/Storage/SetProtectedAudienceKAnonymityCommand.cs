namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// SetProtectedAudienceKAnonymity
    /// </summary>
    public sealed class SetProtectedAudienceKAnonymityCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.setProtectedAudienceKAnonymity";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the owner
        /// </summary>
        [JsonProperty("owner")]
        public string Owner
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the hashes
        /// </summary>
        [JsonProperty("hashes")]
        public byte[][] Hashes
        {
            get;
            set;
        }
    }

    public sealed class SetProtectedAudienceKAnonymityCommandResponse : ICommandResponse<SetProtectedAudienceKAnonymityCommand>
    {
    }
}