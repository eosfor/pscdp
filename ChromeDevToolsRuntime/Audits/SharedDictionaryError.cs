namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// SharedDictionaryError
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SharedDictionaryError
    {
        [EnumMember(Value = "UseErrorCrossOriginNoCorsRequest")]
        UseErrorCrossOriginNoCorsRequest,
        [EnumMember(Value = "UseErrorDictionaryLoadFailure")]
        UseErrorDictionaryLoadFailure,
        [EnumMember(Value = "UseErrorMatchingDictionaryNotUsed")]
        UseErrorMatchingDictionaryNotUsed,
        [EnumMember(Value = "UseErrorUnexpectedContentDictionaryHeader")]
        UseErrorUnexpectedContentDictionaryHeader,
        [EnumMember(Value = "WriteErrorCossOriginNoCorsRequest")]
        WriteErrorCossOriginNoCorsRequest,
        [EnumMember(Value = "WriteErrorDisallowedBySettings")]
        WriteErrorDisallowedBySettings,
        [EnumMember(Value = "WriteErrorExpiredResponse")]
        WriteErrorExpiredResponse,
        [EnumMember(Value = "WriteErrorFeatureDisabled")]
        WriteErrorFeatureDisabled,
        [EnumMember(Value = "WriteErrorInsufficientResources")]
        WriteErrorInsufficientResources,
        [EnumMember(Value = "WriteErrorInvalidMatchField")]
        WriteErrorInvalidMatchField,
        [EnumMember(Value = "WriteErrorInvalidStructuredHeader")]
        WriteErrorInvalidStructuredHeader,
        [EnumMember(Value = "WriteErrorNavigationRequest")]
        WriteErrorNavigationRequest,
        [EnumMember(Value = "WriteErrorNoMatchField")]
        WriteErrorNoMatchField,
        [EnumMember(Value = "WriteErrorNonListMatchDestField")]
        WriteErrorNonListMatchDestField,
        [EnumMember(Value = "WriteErrorNonSecureContext")]
        WriteErrorNonSecureContext,
        [EnumMember(Value = "WriteErrorNonStringIdField")]
        WriteErrorNonStringIdField,
        [EnumMember(Value = "WriteErrorNonStringInMatchDestList")]
        WriteErrorNonStringInMatchDestList,
        [EnumMember(Value = "WriteErrorNonStringMatchField")]
        WriteErrorNonStringMatchField,
        [EnumMember(Value = "WriteErrorNonTokenTypeField")]
        WriteErrorNonTokenTypeField,
        [EnumMember(Value = "WriteErrorRequestAborted")]
        WriteErrorRequestAborted,
        [EnumMember(Value = "WriteErrorShuttingDown")]
        WriteErrorShuttingDown,
        [EnumMember(Value = "WriteErrorTooLongIdField")]
        WriteErrorTooLongIdField,
        [EnumMember(Value = "WriteErrorUnsupportedType")]
        WriteErrorUnsupportedType,
    }
}