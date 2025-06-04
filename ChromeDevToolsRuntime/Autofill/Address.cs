namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// Address
    /// </summary>
    public sealed class Address
    {
        /// <summary>
        /// fields and values defining an address.
        ///</summary>
        [JsonProperty("fields")]
        public AddressField[] Fields
        {
            get;
            set;
        }
    }
}