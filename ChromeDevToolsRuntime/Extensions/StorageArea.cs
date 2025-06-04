namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Storage areas.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageArea
    {
        [EnumMember(Value = "session")]
        Session,
        [EnumMember(Value = "local")]
        Local,
        [EnumMember(Value = "sync")]
        Sync,
        [EnumMember(Value = "managed")]
        Managed,
    }
}