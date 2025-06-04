namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Timeline instance
    /// </summary>
    public sealed class ViewOrScrollTimeline
    {
        /// <summary>
        /// Scroll container node
        ///</summary>
        [JsonProperty("sourceNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? SourceNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the starting scroll position of the timeline
        /// as a length offset in pixels from scroll origin.
        ///</summary>
        [JsonProperty("startOffset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? StartOffset
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the ending scroll position of the timeline
        /// as a length offset in pixels from scroll origin.
        ///</summary>
        [JsonProperty("endOffset", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? EndOffset
        {
            get;
            set;
        }
        /// <summary>
        /// The element whose principal box's visibility in the
        /// scrollport defined the progress of the timeline.
        /// Does not exist for animations with ScrollTimeline
        ///</summary>
        [JsonProperty("subjectNodeId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? SubjectNodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Orientation of the scroll
        ///</summary>
        [JsonProperty("axis")]
        public DOM.ScrollOrientation Axis
        {
            get;
            set;
        }
    }
}