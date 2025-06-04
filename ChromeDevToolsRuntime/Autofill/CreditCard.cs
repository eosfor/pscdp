namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// CreditCard
    /// </summary>
    public sealed class CreditCard
    {
        /// <summary>
        /// 16-digit credit card number.
        ///</summary>
        [JsonProperty("number")]
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// Name of the credit card owner.
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 2-digit expiry month.
        ///</summary>
        [JsonProperty("expiryMonth")]
        public string ExpiryMonth
        {
            get;
            set;
        }
        /// <summary>
        /// 4-digit expiry year.
        ///</summary>
        [JsonProperty("expiryYear")]
        public string ExpiryYear
        {
            get;
            set;
        }
        /// <summary>
        /// 3-digit card verification code.
        ///</summary>
        [JsonProperty("cvc")]
        public string Cvc
        {
            get;
            set;
        }
    }
}