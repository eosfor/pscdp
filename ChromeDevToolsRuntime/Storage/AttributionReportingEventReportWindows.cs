namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingEventReportWindows
    /// </summary>
    public sealed class AttributionReportingEventReportWindows
    {
        /// <summary>
        /// duration in seconds
        ///</summary>
        [JsonProperty("start")]
        public long Start
        {
            get;
            set;
        }
        /// <summary>
        /// duration in seconds
        ///</summary>
        [JsonProperty("ends")]
        public long[] Ends
        {
            get;
            set;
        }
    }
}