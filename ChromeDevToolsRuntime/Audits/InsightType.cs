namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the category of insight that a cookie issue falls under.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InsightType
    {
        [EnumMember(Value = "GitHubResource")]
        GitHubResource,
        [EnumMember(Value = "GracePeriod")]
        GracePeriod,
        [EnumMember(Value = "Heuristics")]
        Heuristics,
    }
}