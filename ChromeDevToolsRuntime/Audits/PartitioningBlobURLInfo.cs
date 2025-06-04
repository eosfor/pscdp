namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PartitioningBlobURLInfo
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PartitioningBlobURLInfo
    {
        [EnumMember(Value = "BlockedCrossPartitionFetching")]
        BlockedCrossPartitionFetching,
        [EnumMember(Value = "EnforceNoopenerForNavigation")]
        EnforceNoopenerForNavigation,
    }
}