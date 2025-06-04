namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// DirectSocketDnsQueryType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectSocketDnsQueryType
    {
        [EnumMember(Value = "ipv4")]
        Ipv4,
        [EnumMember(Value = "ipv6")]
        Ipv6,
    }
}