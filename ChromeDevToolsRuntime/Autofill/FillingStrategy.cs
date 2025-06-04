namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specified whether a filled field was done so by using the html autocomplete attribute or autofill heuristics.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FillingStrategy
    {
        [EnumMember(Value = "autocompleteAttribute")]
        AutocompleteAttribute,
        [EnumMember(Value = "autofillInferred")]
        AutofillInferred,
    }
}