namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates the various types of characteristic operation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CharacteristicOperationType
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "subscribe-to-notifications")]
        SubscribeToNotifications,
        [EnumMember(Value = "unsubscribe-from-notifications")]
        UnsubscribeFromNotifications,
    }
}