namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// GenericIssueErrorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenericIssueErrorType
    {
        [EnumMember(Value = "FormLabelForNameError")]
        FormLabelForNameError,
        [EnumMember(Value = "FormDuplicateIdForInputError")]
        FormDuplicateIdForInputError,
        [EnumMember(Value = "FormInputWithNoLabelError")]
        FormInputWithNoLabelError,
        [EnumMember(Value = "FormAutocompleteAttributeEmptyError")]
        FormAutocompleteAttributeEmptyError,
        [EnumMember(Value = "FormEmptyIdAndNameAttributesForInputError")]
        FormEmptyIdAndNameAttributesForInputError,
        [EnumMember(Value = "FormAriaLabelledByToNonExistingId")]
        FormAriaLabelledByToNonExistingId,
        [EnumMember(Value = "FormInputAssignedAutocompleteValueToIdOrNameAttributeError")]
        FormInputAssignedAutocompleteValueToIdOrNameAttributeError,
        [EnumMember(Value = "FormLabelHasNeitherForNorNestedInput")]
        FormLabelHasNeitherForNorNestedInput,
        [EnumMember(Value = "FormLabelForMatchesNonExistingIdError")]
        FormLabelForMatchesNonExistingIdError,
        [EnumMember(Value = "FormInputHasWrongButWellIntendedAutocompleteValueError")]
        FormInputHasWrongButWellIntendedAutocompleteValueError,
        [EnumMember(Value = "ResponseWasBlockedByORB")]
        ResponseWasBlockedByORB,
    }
}