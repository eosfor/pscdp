namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Representation of a custom property registration through CSS.registerProperty
    /// </summary>
    public sealed class CSSPropertyRegistration
    {
        /// <summary>
        /// propertyName
        ///</summary>
        [JsonProperty("propertyName")]
        public string PropertyName
        {
            get;
            set;
        }
        /// <summary>
        /// initialValue
        ///</summary>
        [JsonProperty("initialValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Value InitialValue
        {
            get;
            set;
        }
        /// <summary>
        /// inherits
        ///</summary>
        [JsonProperty("inherits")]
        public bool Inherits
        {
            get;
            set;
        }
        /// <summary>
        /// syntax
        ///</summary>
        [JsonProperty("syntax")]
        public string Syntax
        {
            get;
            set;
        }
    }
}