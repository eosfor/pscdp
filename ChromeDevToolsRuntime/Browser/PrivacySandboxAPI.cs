namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PrivacySandboxAPI
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivacySandboxAPI
    {
        [EnumMember(Value = "BiddingAndAuctionServices")]
        BiddingAndAuctionServices,
        [EnumMember(Value = "TrustedKeyValue")]
        TrustedKeyValue,
    }
}