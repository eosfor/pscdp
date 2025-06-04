namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates the various types of characteristic write.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CharacteristicWriteType
    {
        [EnumMember(Value = "write-default-deprecated")]
        WriteDefaultDeprecated,
        [EnumMember(Value = "write-with-response")]
        WriteWithResponse,
        [EnumMember(Value = "write-without-response")]
        WriteWithoutResponse,
    }
}