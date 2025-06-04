namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ContainerSelector logical axes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LogicalAxes
    {
        [EnumMember(Value = "Inline")]
        Inline,
        [EnumMember(Value = "Block")]
        Block,
        [EnumMember(Value = "Both")]
        Both,
    }
}