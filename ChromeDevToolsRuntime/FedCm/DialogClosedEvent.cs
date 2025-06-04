namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using Newtonsoft.Json;

    /// <summary>
    /// Triggered when a dialog is closed, either by user action, JS abort,
    /// or a command below.
    /// </summary>
    public sealed class DialogClosedEvent : IEvent
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
    }
}