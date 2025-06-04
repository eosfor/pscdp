namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// ClientNavigationReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientNavigationReason
    {
        [EnumMember(Value = "anchorClick")]
        AnchorClick,
        [EnumMember(Value = "formSubmissionGet")]
        FormSubmissionGet,
        [EnumMember(Value = "formSubmissionPost")]
        FormSubmissionPost,
        [EnumMember(Value = "httpHeaderRefresh")]
        HttpHeaderRefresh,
        [EnumMember(Value = "initialFrameNavigation")]
        InitialFrameNavigation,
        [EnumMember(Value = "metaTagRefresh")]
        MetaTagRefresh,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "pageBlockInterstitial")]
        PageBlockInterstitial,
        [EnumMember(Value = "reload")]
        Reload,
        [EnumMember(Value = "scriptInitiated")]
        ScriptInitiated,
    }
}