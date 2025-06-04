namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// The URLs that each account has
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountUrlType
    {
        [EnumMember(Value = "TermsOfService")]
        TermsOfService,
        [EnumMember(Value = "PrivacyPolicy")]
        PrivacyPolicy,
    }
}