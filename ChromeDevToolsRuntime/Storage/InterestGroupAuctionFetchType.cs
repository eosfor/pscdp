namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of network fetches auctions can do.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterestGroupAuctionFetchType
    {
        [EnumMember(Value = "bidderJs")]
        BidderJs,
        [EnumMember(Value = "bidderWasm")]
        BidderWasm,
        [EnumMember(Value = "sellerJs")]
        SellerJs,
        [EnumMember(Value = "bidderTrustedSignals")]
        BidderTrustedSignals,
        [EnumMember(Value = "sellerTrustedSignals")]
        SellerTrustedSignals,
    }
}