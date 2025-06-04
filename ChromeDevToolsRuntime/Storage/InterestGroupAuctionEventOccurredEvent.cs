namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// An auction involving interest groups is taking place. These events are
    /// target-specific.
    /// </summary>
    public sealed class InterestGroupAuctionEventOccurredEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the eventTime
        /// </summary>
        [JsonProperty("eventTime")]
        public double EventTime
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public InterestGroupAuctionEventType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the uniqueAuctionId
        /// </summary>
        [JsonProperty("uniqueAuctionId")]
        public string UniqueAuctionId
        {
            get;
            set;
        }
        /// <summary>
        /// Set for child auctions.
        /// </summary>
        [JsonProperty("parentAuctionId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParentAuctionId
        {
            get;
            set;
        }
        /// <summary>
        /// Set for started and configResolved
        /// </summary>
        [JsonProperty("auctionConfig", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object AuctionConfig
        {
            get;
            set;
        }
    }
}