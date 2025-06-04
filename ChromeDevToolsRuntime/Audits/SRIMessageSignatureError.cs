namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// SRIMessageSignatureError
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SRIMessageSignatureError
    {
        [EnumMember(Value = "MissingSignatureHeader")]
        MissingSignatureHeader,
        [EnumMember(Value = "MissingSignatureInputHeader")]
        MissingSignatureInputHeader,
        [EnumMember(Value = "InvalidSignatureHeader")]
        InvalidSignatureHeader,
        [EnumMember(Value = "InvalidSignatureInputHeader")]
        InvalidSignatureInputHeader,
        [EnumMember(Value = "SignatureHeaderValueIsNotByteSequence")]
        SignatureHeaderValueIsNotByteSequence,
        [EnumMember(Value = "SignatureHeaderValueIsParameterized")]
        SignatureHeaderValueIsParameterized,
        [EnumMember(Value = "SignatureHeaderValueIsIncorrectLength")]
        SignatureHeaderValueIsIncorrectLength,
        [EnumMember(Value = "SignatureInputHeaderMissingLabel")]
        SignatureInputHeaderMissingLabel,
        [EnumMember(Value = "SignatureInputHeaderValueNotInnerList")]
        SignatureInputHeaderValueNotInnerList,
        [EnumMember(Value = "SignatureInputHeaderValueMissingComponents")]
        SignatureInputHeaderValueMissingComponents,
        [EnumMember(Value = "SignatureInputHeaderInvalidComponentType")]
        SignatureInputHeaderInvalidComponentType,
        [EnumMember(Value = "SignatureInputHeaderInvalidComponentName")]
        SignatureInputHeaderInvalidComponentName,
        [EnumMember(Value = "SignatureInputHeaderInvalidHeaderComponentParameter")]
        SignatureInputHeaderInvalidHeaderComponentParameter,
        [EnumMember(Value = "SignatureInputHeaderInvalidDerivedComponentParameter")]
        SignatureInputHeaderInvalidDerivedComponentParameter,
        [EnumMember(Value = "SignatureInputHeaderKeyIdLength")]
        SignatureInputHeaderKeyIdLength,
        [EnumMember(Value = "SignatureInputHeaderInvalidParameter")]
        SignatureInputHeaderInvalidParameter,
        [EnumMember(Value = "SignatureInputHeaderMissingRequiredParameters")]
        SignatureInputHeaderMissingRequiredParameters,
        [EnumMember(Value = "ValidationFailedSignatureExpired")]
        ValidationFailedSignatureExpired,
        [EnumMember(Value = "ValidationFailedInvalidLength")]
        ValidationFailedInvalidLength,
        [EnumMember(Value = "ValidationFailedSignatureMismatch")]
        ValidationFailedSignatureMismatch,
        [EnumMember(Value = "ValidationFailedIntegrityMismatch")]
        ValidationFailedIntegrityMismatch,
    }
}