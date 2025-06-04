namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// SRIMessageSignatureIssueDetails
    /// </summary>
    public sealed class SRIMessageSignatureIssueDetails
    {
        /// <summary>
        /// error
        ///</summary>
        [JsonProperty("error")]
        public SRIMessageSignatureError Error
        {
            get;
            set;
        }
        /// <summary>
        /// signatureBase
        ///</summary>
        [JsonProperty("signatureBase")]
        public string SignatureBase
        {
            get;
            set;
        }
        /// <summary>
        /// integrityAssertions
        ///</summary>
        [JsonProperty("integrityAssertions")]
        public string[] IntegrityAssertions
        {
            get;
            set;
        }
        /// <summary>
        /// request
        ///</summary>
        [JsonProperty("request")]
        public AffectedRequest Request
        {
            get;
            set;
        }
    }
}