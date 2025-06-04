namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// UserReidentificationIssueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserReidentificationIssueType
    {
        [EnumMember(Value = "BlockedFrameNavigation")]
        BlockedFrameNavigation,
        [EnumMember(Value = "BlockedSubresource")]
        BlockedSubresource,
    }
}