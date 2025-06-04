namespace BaristaLabs.ChromeDevTools.Runtime.WebAuthn
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
    /// </summary>
    public sealed class SetResponseOverrideBitsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "WebAuthn.setResponseOverrideBits";
        
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
        /// If isBogusSignature is set, overrides the signature in the authenticator response to be zero.
        /// Defaults to false.
        /// </summary>
        [JsonProperty("isBogusSignature", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsBogusSignature
        {
            get;
            set;
        }
        /// <summary>
        /// If isBadUV is set, overrides the UV bit in the flags in the authenticator response to
        /// be zero. Defaults to false.
        /// </summary>
        [JsonProperty("isBadUV", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsBadUV
        {
            get;
            set;
        }
        /// <summary>
        /// If isBadUP is set, overrides the UP bit in the flags in the authenticator response to
        /// be zero. Defaults to false.
        /// </summary>
        [JsonProperty("isBadUP", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsBadUP
        {
            get;
            set;
        }
    }

    public sealed class SetResponseOverrideBitsCommandResponse : ICommandResponse<SetResponseOverrideBitsCommand>
    {
    }
}