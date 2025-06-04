namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PressureState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PressureState
    {
        [EnumMember(Value = "nominal")]
        Nominal,
        [EnumMember(Value = "fair")]
        Fair,
        [EnumMember(Value = "serious")]
        Serious,
        [EnumMember(Value = "critical")]
        Critical,
    }
}