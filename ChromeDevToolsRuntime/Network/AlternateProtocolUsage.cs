namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The reason why Chrome uses a specific transport protocol for HTTP semantics.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlternateProtocolUsage
    {
        [EnumMember(Value = "alternativeJobWonWithoutRace")]
        AlternativeJobWonWithoutRace,
        [EnumMember(Value = "alternativeJobWonRace")]
        AlternativeJobWonRace,
        [EnumMember(Value = "mainJobWonRace")]
        MainJobWonRace,
        [EnumMember(Value = "mappingMissing")]
        MappingMissing,
        [EnumMember(Value = "broken")]
        Broken,
        [EnumMember(Value = "dnsAlpnH3JobWonWithoutRace")]
        DnsAlpnH3JobWonWithoutRace,
        [EnumMember(Value = "dnsAlpnH3JobWonRace")]
        DnsAlpnH3JobWonRace,
        [EnumMember(Value = "unspecifiedReason")]
        UnspecifiedReason,
    }
}