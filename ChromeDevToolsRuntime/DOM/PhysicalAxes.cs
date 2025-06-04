namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ContainerSelector physical axes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhysicalAxes
    {
        [EnumMember(Value = "Horizontal")]
        Horizontal,
        [EnumMember(Value = "Vertical")]
        Vertical,
        [EnumMember(Value = "Both")]
        Both,
    }
}