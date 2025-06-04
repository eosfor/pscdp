namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ContentSecurityPolicySource
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentSecurityPolicySource
    {
        [EnumMember(Value = "HTTP")]
        HTTP,
        [EnumMember(Value = "Meta")]
        Meta,
    }
}