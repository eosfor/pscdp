namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fired when a navigation starts. This event is fired for both
    /// renderer-initiated and browser-initiated navigations. For renderer-initiated
    /// navigations, the event is fired after `frameRequestedNavigation`.
    /// Navigation may still be cancelled after the event is issued. Multiple events
    /// can be fired for a single navigation, for example, when a same-document
    /// navigation becomes a cross-document navigation (such as in the case of a
    /// frameset).
    /// </summary>
    public sealed class FrameStartedNavigatingEvent : IEvent
    {
        /// <summary>
        /// ID of the frame that is being navigated.
        /// </summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The URL the navigation started with. The final URL can be different.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Loader identifier. Even though it is present in case of same-document
        /// navigation, the previously committed loaderId would not change unless
        /// the navigation changes from a same-document to a cross-document
        /// navigation.
        /// </summary>
        [JsonProperty("loaderId")]
        public string LoaderId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the navigationType
        /// </summary>
        [JsonProperty("navigationType")]
        public string NavigationType
        {
            get;
            set;
        }
    }
}