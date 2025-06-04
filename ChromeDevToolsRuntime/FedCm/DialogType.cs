namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The types of FedCM dialogs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DialogType
    {
        [EnumMember(Value = "AccountChooser")]
        AccountChooser,
        [EnumMember(Value = "AutoReauthn")]
        AutoReauthn,
        [EnumMember(Value = "ConfirmIdpLogin")]
        ConfirmIdpLogin,
        [EnumMember(Value = "Error")]
        Error,
    }
}