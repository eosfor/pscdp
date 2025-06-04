namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// SelectElementAccessibilityIssueReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelectElementAccessibilityIssueReason
    {
        [EnumMember(Value = "DisallowedSelectChild")]
        DisallowedSelectChild,
        [EnumMember(Value = "DisallowedOptGroupChild")]
        DisallowedOptGroupChild,
        [EnumMember(Value = "NonPhrasingContentOptionChild")]
        NonPhrasingContentOptionChild,
        [EnumMember(Value = "InteractiveContentOptionChild")]
        InteractiveContentOptionChild,
        [EnumMember(Value = "InteractiveContentLegendChild")]
        InteractiveContentLegendChild,
    }
}