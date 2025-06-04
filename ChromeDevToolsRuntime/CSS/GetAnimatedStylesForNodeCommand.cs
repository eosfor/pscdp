namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the styles coming from animations & transitions
    /// including the animation & transition styles coming from inheritance chain.
    /// </summary>
    public sealed class GetAnimatedStylesForNodeCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getAnimatedStylesForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    }

    public sealed class GetAnimatedStylesForNodeCommandResponse : ICommandResponse<GetAnimatedStylesForNodeCommand>
    {
        /// <summary>
        /// Styles coming from animations.
        ///</summary>
        [JsonProperty("animationStyles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSAnimationStyle[] AnimationStyles
        {
            get;
            set;
        }
        /// <summary>
        /// Style coming from transitions.
        ///</summary>
        [JsonProperty("transitionsStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle TransitionsStyle
        {
            get;
            set;
        }
        /// <summary>
        /// Inherited style entries for animationsStyle and transitionsStyle from
        /// the inheritance chain of the element.
        ///</summary>
        [JsonProperty("inherited", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InheritedAnimatedStyleEntry[] Inherited
        {
            get;
            set;
        }
    }
}