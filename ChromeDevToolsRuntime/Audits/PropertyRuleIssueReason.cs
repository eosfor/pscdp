namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PropertyRuleIssueReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PropertyRuleIssueReason
    {
        [EnumMember(Value = "InvalidSyntax")]
        InvalidSyntax,
        [EnumMember(Value = "InvalidInitialValue")]
        InvalidInitialValue,
        [EnumMember(Value = "InvalidInherits")]
        InvalidInherits,
        [EnumMember(Value = "InvalidName")]
        InvalidName,
    }
}