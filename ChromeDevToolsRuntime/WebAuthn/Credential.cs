namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Credential
    /// </summary>
    public sealed class Credential
    {
        /// <summary>
        /// credentialId
        ///</summary>
        [JsonProperty("credentialId")]
        public byte[] CredentialId
        {
            get;
            set;
        }
        /// <summary>
        /// isResidentCredential
        ///</summary>
        [JsonProperty("isResidentCredential")]
        public bool IsResidentCredential
        {
            get;
            set;
        }
        /// <summary>
        /// Relying Party ID the credential is scoped to. Must be set when adding a
        /// credential.
        ///</summary>
        [JsonProperty("rpId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RpId
        {
            get;
            set;
        }
        /// <summary>
        /// The ECDSA P-256 private key in PKCS#8 format.
        ///</summary>
        [JsonProperty("privateKey")]
        public byte[] PrivateKey
        {
            get;
            set;
        }
        /// <summary>
        /// An opaque byte sequence with a maximum size of 64 bytes mapping the
        /// credential to a specific user.
        ///</summary>
        [JsonProperty("userHandle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] UserHandle
        {
            get;
            set;
        }
        /// <summary>
        /// Signature counter. This is incremented by one for each successful
        /// assertion.
        /// See https://w3c.github.io/webauthn/#signature-counter
        ///</summary>
        [JsonProperty("signCount")]
        public long SignCount
        {
            get;
            set;
        }
        /// <summary>
        /// The large blob associated with the credential.
        /// See https://w3c.github.io/webauthn/#sctn-large-blob-extension
        ///</summary>
        [JsonProperty("largeBlob", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public byte[] LargeBlob
        {
            get;
            set;
        }
        /// <summary>
        /// Assertions returned by this credential will have the backup eligibility
        /// (BE) flag set to this value. Defaults to the authenticator's
        /// defaultBackupEligibility value.
        ///</summary>
        [JsonProperty("backupEligibility", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BackupEligibility
        {
            get;
            set;
        }
        /// <summary>
        /// Assertions returned by this credential will have the backup state (BS)
        /// flag set to this value. Defaults to the authenticator's
        /// defaultBackupState value.
        ///</summary>
        [JsonProperty("backupState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BackupState
        {
            get;
            set;
        }
        /// <summary>
        /// The credential's user.name property. Equivalent to empty if not set.
        /// https://w3c.github.io/webauthn/#dom-publickeycredentialentity-name
        ///</summary>
        [JsonProperty("userName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// The credential's user.displayName property. Equivalent to empty if
        /// not set.
        /// https://w3c.github.io/webauthn/#dom-publickeycredentialuserentity-displayname
        ///</summary>
        [JsonProperty("userDisplayName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserDisplayName
        {
            get;
            set;
        }
    }
}