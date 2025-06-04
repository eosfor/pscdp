namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Preloading status values, see also PreloadingTriggeringOutcome. This
    /// status is shared by prefetchStatusUpdated and prerenderStatusUpdated.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PreloadingStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Ready")]
        Ready,
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "Failure")]
        Failure,
        [EnumMember(Value = "NotSupported")]
        NotSupported,
    }
}