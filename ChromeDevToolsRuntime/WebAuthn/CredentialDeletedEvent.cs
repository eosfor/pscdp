namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Triggered when a credential is deleted, e.g. through
    /// PublicKeyCredential.signalUnknownCredential().
    /// </summary>
    public sealed class CredentialDeletedEvent : IEvent
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
        /// Gets or sets the credentialId
        /// </summary>
        [JsonProperty("credentialId")]
        public byte[] CredentialId
        {
            get;
            set;
        }
    }
}