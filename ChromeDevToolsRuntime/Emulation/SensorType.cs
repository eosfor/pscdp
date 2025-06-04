namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Used to specify sensor types to emulate.
    /// See https://w3c.github.io/sensors/#automation for more information.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SensorType
    {
        [EnumMember(Value = "absolute-orientation")]
        AbsoluteOrientation,
        [EnumMember(Value = "accelerometer")]
        Accelerometer,
        [EnumMember(Value = "ambient-light")]
        AmbientLight,
        [EnumMember(Value = "gravity")]
        Gravity,
        [EnumMember(Value = "gyroscope")]
        Gyroscope,
        [EnumMember(Value = "linear-acceleration")]
        LinearAcceleration,
        [EnumMember(Value = "magnetometer")]
        Magnetometer,
        [EnumMember(Value = "relative-orientation")]
        RelativeOrientation,
    }
}