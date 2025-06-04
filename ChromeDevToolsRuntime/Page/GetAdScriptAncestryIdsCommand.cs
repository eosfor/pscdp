namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// GetAdScriptAncestryIds
    /// </summary>
    public sealed class GetAdScriptAncestryIdsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getAdScriptAncestryIds";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the frameId
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    }

    public sealed class GetAdScriptAncestryIdsCommandResponse : ICommandResponse<GetAdScriptAncestryIdsCommand>
    {
        /// <summary>
        /// The ancestry chain of ad script identifiers leading to this frame's
        /// creation, ordered from the most immediate script (in the frame creation
        /// stack) to more distant ancestors (that created the immediately preceding
        /// script). Only sent if frame is labelled as an ad and ids are available.
        ///</summary>
        [JsonProperty("adScriptAncestryIds")]
        public AdScriptId[] AdScriptAncestryIds
        {
            get;
            set;
        }
    }
}