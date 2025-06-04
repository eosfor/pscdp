namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Triggered when a credential is added to an authenticator.
    /// </summary>
    public sealed class CredentialAddedEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the authenticatorId
        /// </summary>
        [JsonProperty("authenticatorId")]
        public string AuthenticatorId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the credential
        /// </summary>
        [JsonProperty("credential")]
        public Credential Credential
        {
            get;
            set;
        }
    }
}