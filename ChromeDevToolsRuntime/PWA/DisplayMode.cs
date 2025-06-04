namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// If user prefers opening the app in browser or an app window.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayMode
    {
        [EnumMember(Value = "standalone")]
        Standalone,
        [EnumMember(Value = "browser")]
        Browser,
    }
}