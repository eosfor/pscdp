namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of auction events.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterestGroupAuctionEventType
    {
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "configResolved")]
        ConfigResolved,
    }
}