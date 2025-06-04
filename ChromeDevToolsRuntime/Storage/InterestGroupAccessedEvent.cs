namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// One of the interest groups was accessed. Note that these events are global
    /// to all targets sharing an interest group store.
    /// </summary>
    public sealed class InterestGroupAccessedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the accessTime
        /// </summary>
        [JsonProperty("accessTime")]
        public double AccessTime
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public InterestGroupAccessType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the ownerOrigin
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
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
        /// For topLevelBid/topLevelAdditionalBid, and when appropriate,
        /// win and additionalBidWin
        /// </summary>
        [JsonProperty("componentSellerOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ComponentSellerOrigin
        {
            get;
            set;
        }
        /// <summary>
        /// For bid or somethingBid event, if done locally and not on a server.
        /// </summary>
        [JsonProperty("bid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Bid
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the bidCurrency
        /// </summary>
        [JsonProperty("bidCurrency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BidCurrency
        {
            get;
            set;
        }
        /// <summary>
        /// For non-global events --- links to interestGroupAuctionEvent
        /// </summary>
        [JsonProperty("uniqueAuctionId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UniqueAuctionId
        {
            get;
            set;
        }
    }
}