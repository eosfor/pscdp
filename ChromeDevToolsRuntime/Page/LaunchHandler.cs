namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// LaunchHandler
    /// </summary>
    public sealed class LaunchHandler
    {
        /// <summary>
        /// clientMode
        ///</summary>
        [JsonProperty("clientMode")]
        public string ClientMode
        {
            get;
            set;
        }
    }
}