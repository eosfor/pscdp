namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS function argument representation.
    /// </summary>
    public sealed class CSSFunctionParameter
    {
        /// <summary>
        /// The parameter name.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// The parameter type.
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}