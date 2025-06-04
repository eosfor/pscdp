namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines how an address can be displayed like in chrome://settings/addresses.
    /// Address UI is a two dimensional array, each inner array is an "address information line", and when rendered in a UI surface should be displayed as such.
    /// The following address UI for instance:
    /// [[{name: "GIVE_NAME", value: "Jon"}, {name: "FAMILY_NAME", value: "Doe"}], [{name: "CITY", value: "Munich"}, {name: "ZIP", value: "81456"}]]
    /// should allow the receiver to render:
    /// Jon Doe
    /// Munich 81456
    /// </summary>
    public sealed class AddressUI
    {
        /// <summary>
        /// A two dimension array containing the representation of values from an address profile.
        ///</summary>
        [JsonProperty("addressFields")]
        public AddressFields[] AddressFields
        {
            get;
            set;
        }
    }
}