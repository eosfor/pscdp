namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Specifies which auctions a particular network fetch may be related to, and
    /// in what role. Note that it is not ordered with respect to
    /// Network.requestWillBeSent (but will happen before loadingFinished
    /// loadingFailed).
    /// </summary>
    public sealed class InterestGroupAuctionNetworkRequestCreatedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the type
        /// </summary>
        [JsonProperty("type")]
        public InterestGroupAuctionFetchType Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the requestId
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
        /// <summary>
        /// This is the set of the auctions using the worklet that issued this
        /// request.  In the case of trusted signals, it's possible that only some of
        /// them actually care about the keys being queried.
        /// </summary>
        [JsonProperty("auctions")]
        public string[] Auctions
        {
            get;
            set;
        }
    }
}