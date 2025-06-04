namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emitted when an address form is filled.
    /// </summary>
    public sealed class AddressFormFilledEvent : IEvent
    {
        /// <summary>
        /// Information about the fields that were filled
        /// </summary>
        [JsonProperty("filledFields")]
        public FilledField[] FilledFields
        {
            get;
            set;
        }
        /// <summary>
        /// An UI representation of the address used to fill the form.
        /// Consists of a 2D array where each child represents an address/profile line.
        /// </summary>
        [JsonProperty("addressUi")]
        public AddressUI AddressUi
        {
            get;
            set;
        }
    }
}