namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// StorageBucketsDurability
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageBucketsDurability
    {
        [EnumMember(Value = "relaxed")]
        Relaxed,
        [EnumMember(Value = "strict")]
        Strict,
    }
}