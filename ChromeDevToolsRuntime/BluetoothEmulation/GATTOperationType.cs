namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates the various types of GATT event.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GATTOperationType
    {
        [EnumMember(Value = "connection")]
        Connection,
        [EnumMember(Value = "discovery")]
        Discovery,
    }
}