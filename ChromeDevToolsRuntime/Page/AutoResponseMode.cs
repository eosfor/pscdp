namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of possible auto-response for permission / prompt dialogs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoResponseMode
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "autoAccept")]
        AutoAccept,
        [EnumMember(Value = "autoReject")]
        AutoReject,
        [EnumMember(Value = "autoOptOut")]
        AutoOptOut,
    }
}