namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum indicating the type of a CSS rule, used to represent the order of a style rule's ancestors.
    /// This list only contains rule types that are collected during the ancestor rule collection.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CSSRuleType
    {
        [EnumMember(Value = "MediaRule")]
        MediaRule,
        [EnumMember(Value = "SupportsRule")]
        SupportsRule,
        [EnumMember(Value = "ContainerRule")]
        ContainerRule,
        [EnumMember(Value = "LayerRule")]
        LayerRule,
        [EnumMember(Value = "ScopeRule")]
        ScopeRule,
        [EnumMember(Value = "StyleRule")]
        StyleRule,
        [EnumMember(Value = "StartingStyleRule")]
        StartingStyleRule,
    }
}