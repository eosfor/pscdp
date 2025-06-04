namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of shared storage access scopes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SharedStorageAccessScope
    {
        [EnumMember(Value = "window")]
        Window,
        [EnumMember(Value = "sharedStorageWorklet")]
        SharedStorageWorklet,
        [EnumMember(Value = "protectedAudienceWorklet")]
        ProtectedAudienceWorklet,
        [EnumMember(Value = "header")]
        Header,
    }
}