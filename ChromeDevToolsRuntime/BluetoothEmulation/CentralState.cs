namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates the various states of Central.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CentralState
    {
        [EnumMember(Value = "absent")]
        Absent,
        [EnumMember(Value = "powered-off")]
        PoweredOff,
        [EnumMember(Value = "powered-on")]
        PoweredOn,
    }
}