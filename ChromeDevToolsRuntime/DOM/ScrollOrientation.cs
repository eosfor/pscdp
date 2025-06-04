namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Physical scroll orientation
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScrollOrientation
    {
        [EnumMember(Value = "horizontal")]
        Horizontal,
        [EnumMember(Value = "vertical")]
        Vertical,
    }
}