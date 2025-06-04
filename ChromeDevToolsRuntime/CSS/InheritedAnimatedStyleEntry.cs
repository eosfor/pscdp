namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Inherited CSS style collection for animated styles from ancestor node.
    /// </summary>
    public sealed class InheritedAnimatedStyleEntry
    {
        /// <summary>
        /// Styles coming from the animations of the ancestor, if any, in the style inheritance chain.
        ///</summary>
        [JsonProperty("animationStyles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSAnimationStyle[] AnimationStyles
        {
            get;
            set;
        }
        /// <summary>
        /// The style coming from the transitions of the ancestor, if any, in the style inheritance chain.
        ///</summary>
        [JsonProperty("transitionsStyle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CSSStyle TransitionsStyle
        {
            get;
            set;
        }
    }
}