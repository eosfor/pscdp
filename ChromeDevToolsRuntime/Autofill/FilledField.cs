namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// FilledField
    /// </summary>
    public sealed class FilledField
    {
        /// <summary>
        /// The type of the field, e.g text, password etc.
        ///</summary>
        [JsonProperty("htmlType")]
        public string HtmlType
        {
            get;
            set;
        }
        /// <summary>
        /// the html id
        ///</summary>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// the html name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// the field value
        ///</summary>
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
        /// <summary>
        /// The actual field type, e.g FAMILY_NAME
        ///</summary>
        [JsonProperty("autofillType")]
        public string AutofillType
        {
            get;
            set;
        }
        /// <summary>
        /// The filling strategy
        ///</summary>
        [JsonProperty("fillingStrategy")]
        public FillingStrategy FillingStrategy
        {
            get;
            set;
        }
        /// <summary>
        /// The frame the field belongs to
        ///</summary>
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The form field's DOM node
        ///</summary>
        [JsonProperty("fieldId")]
        public long FieldId
        {
            get;
            set;
        }
    }
}