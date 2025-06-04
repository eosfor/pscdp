namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PressureSource
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PressureSource
    {
        [EnumMember(Value = "cpu")]
        Cpu,
    }
}