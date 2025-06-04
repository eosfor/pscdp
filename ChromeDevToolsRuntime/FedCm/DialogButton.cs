namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The buttons on the FedCM dialog.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DialogButton
    {
        [EnumMember(Value = "ConfirmIdpLoginContinue")]
        ConfirmIdpLoginContinue,
        [EnumMember(Value = "ErrorGotIt")]
        ErrorGotIt,
        [EnumMember(Value = "ErrorMoreDetails")]
        ErrorMoreDetails,
    }
}