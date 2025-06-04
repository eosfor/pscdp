namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// RuleSetErrorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleSetErrorType
    {
        [EnumMember(Value = "SourceIsNotJsonObject")]
        SourceIsNotJsonObject,
        [EnumMember(Value = "InvalidRulesSkipped")]
        InvalidRulesSkipped,
    }
}