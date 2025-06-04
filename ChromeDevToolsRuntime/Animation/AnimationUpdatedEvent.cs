namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Event for animation that has been updated.
    /// </summary>
    public sealed class AnimationUpdatedEvent : IEvent
    {
        /// <summary>
        /// Animation that was updated.
        /// </summary>
        [JsonProperty("animation")]
        public Animation Animation
        {
            get;
            set;
        }
    }
}