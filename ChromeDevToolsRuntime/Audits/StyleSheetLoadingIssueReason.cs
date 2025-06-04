namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// StyleSheetLoadingIssueReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StyleSheetLoadingIssueReason
    {
        [EnumMember(Value = "LateImportRule")]
        LateImportRule,
        [EnumMember(Value = "RequestFailed")]
        RequestFailed,
    }
}