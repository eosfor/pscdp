namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// A list of address fields.
    /// </summary>
    public sealed class AddressFields
    {
        /// <summary>
        /// fields
        ///</summary>
        [JsonProperty("fields")]
        public AddressField[] Fields
        {
            get;
            set;
        }
    }
}