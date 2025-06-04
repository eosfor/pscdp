namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Allows setting credential properties.
    /// https://w3c.github.io/webauthn/#sctn-automation-set-credential-properties
    /// </summary>
    public sealed class SetCredentialPropertiesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.setCredentialProperties";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

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
        /// <summary>
        /// Gets or sets the backupEligibility
        /// </summary>
        [JsonProperty("backupEligibility", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BackupEligibility
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the backupState
        /// </summary>
        [JsonProperty("backupState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? BackupState
        {
            get;
            set;
        }
    }

    public sealed class SetCredentialPropertiesCommandResponse : ICommandResponse<SetCredentialPropertiesCommand>
    {
    }
}