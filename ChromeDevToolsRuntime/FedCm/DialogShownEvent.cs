namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// DialogShown
    /// </summary>
    public sealed class DialogShownEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the dialogId
        /// </summary>
        [JsonProperty("dialogId")]
        public string DialogId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the dialogType
        /// </summary>
        [JsonProperty("dialogType")]
        public DialogType DialogType
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the accounts
        /// </summary>
        [JsonProperty("accounts")]
        public Account[] Accounts
        {
            get;
            set;
        }
        /// <summary>
        /// These exist primarily so that the caller can verify the
        /// RP context was used appropriately.
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the subtitle
        /// </summary>
        [JsonProperty("subtitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Subtitle
        {
            get;
            set;
        }
    }
}