namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The state of the target window.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WindowState
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "minimized")]
        Minimized,
        [EnumMember(Value = "maximized")]
        Maximized,
        [EnumMember(Value = "fullscreen")]
        Fullscreen,
    }
}