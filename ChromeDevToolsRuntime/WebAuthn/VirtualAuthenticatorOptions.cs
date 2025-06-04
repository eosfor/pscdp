namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// VirtualAuthenticatorOptions
    /// </summary>
    public sealed class VirtualAuthenticatorOptions
    {
        /// <summary>
        /// protocol
        ///</summary>
        [JsonProperty("protocol")]
        public AuthenticatorProtocol Protocol
        {
            get;
            set;
        }
        /// <summary>
        /// Defaults to ctap2_0. Ignored if |protocol| == u2f.
        ///</summary>
        [JsonProperty("ctap2Version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Ctap2Version? Ctap2Version
        {
            get;
            set;
        }
        /// <summary>
        /// transport
        ///</summary>
        [JsonProperty("transport")]
        public AuthenticatorTransport Transport
        {
            get;
            set;
        }
        /// <summary>
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasResidentKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasResidentKey
        {
            get;
            set;
        }
        /// <summary>
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasUserVerification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasUserVerification
        {
            get;
            set;
        }
        /// <summary>
        /// If set to true, the authenticator will support the largeBlob extension.
        /// https://w3c.github.io/webauthn#largeBlob
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasLargeBlob", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasLargeBlob
        {
            get;
            set;
        }
        /// <summary>
        /// If set to true, the authenticator will support the credBlob extension.
        /// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasCredBlob", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasCredBlob
        {
            get;
            set;
        }
        /// <summary>
        /// If set to true, the authenticator will support the minPinLength extension.
        /// https://fidoalliance.org/specs/fido-v2.1-ps-20210615/fido-client-to-authenticator-protocol-v2.1-ps-20210615.html#sctn-minpinlength-extension
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasMinPinLength", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasMinPinLength
        {
            get;
            set;
        }
        /// <summary>
        /// If set to true, the authenticator will support the prf extension.
        /// https://w3c.github.io/webauthn/#prf-extension
        /// Defaults to false.
        ///</summary>
        [JsonProperty("hasPrf", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? HasPrf
        {
            get;
            set;
        }
        /// <summary>
        /// If set to true, tests of user presence will succeed immediately.
        /// Otherwise, they will not be resolved. Defaults to true.
        ///</summary>
        [JsonProperty("automaticPresenceSimulation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AutomaticPresenceSimulation
        {
            get;
            set;
        }
        /// <summary>
        /// Sets whether User Verification succeeds or fails for an authenticator.
        /// Defaults to false.
        ///</summary>
        [JsonProperty("isUserVerified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsUserVerified
        {
            get;
            set;
        }
        /// <summary>
        /// Credentials created by this authenticator will have the backup
        /// eligibility (BE) flag set to this value. Defaults to false.
        /// https://w3c.github.io/webauthn/#sctn-credential-backup
        ///</summary>
        [JsonProperty("defaultBackupEligibility", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DefaultBackupEligibility
        {
            get;
            set;
        }
        /// <summary>
        /// Credentials created by this authenticator will have the backup state
        /// (BS) flag set to this value. Defaults to false.
        /// https://w3c.github.io/webauthn/#sctn-credential-backup
        ///</summary>
        [JsonProperty("defaultBackupState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DefaultBackupState
        {
            get;
            set;
        }
    }
}