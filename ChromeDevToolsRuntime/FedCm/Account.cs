namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// Corresponds to IdentityRequestAccount
    /// </summary>
    public sealed class Account
    {
        /// <summary>
        /// accountId
        ///</summary>
        [JsonProperty("accountId")]
        public string AccountId
        {
            get;
            set;
        }
        /// <summary>
        /// email
        ///</summary>
        [JsonProperty("email")]
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// givenName
        ///</summary>
        [JsonProperty("givenName")]
        public string GivenName
        {
            get;
            set;
        }
        /// <summary>
        /// pictureUrl
        ///</summary>
        [JsonProperty("pictureUrl")]
        public string PictureUrl
        {
            get;
            set;
        }
        /// <summary>
        /// idpConfigUrl
        ///</summary>
        [JsonProperty("idpConfigUrl")]
        public string IdpConfigUrl
        {
            get;
            set;
        }
        /// <summary>
        /// idpLoginUrl
        ///</summary>
        [JsonProperty("idpLoginUrl")]
        public string IdpLoginUrl
        {
            get;
            set;
        }
        /// <summary>
        /// loginState
        ///</summary>
        [JsonProperty("loginState")]
        public LoginState LoginState
        {
            get;
            set;
        }
        /// <summary>
        /// These two are only set if the loginState is signUp
        ///</summary>
        [JsonProperty("termsOfServiceUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TermsOfServiceUrl
        {
            get;
            set;
        }
        /// <summary>
        /// privacyPolicyUrl
        ///</summary>
        [JsonProperty("privacyPolicyUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrivacyPolicyUrl
        {
            get;
            set;
        }
    }
}