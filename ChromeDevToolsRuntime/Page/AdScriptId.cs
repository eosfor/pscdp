namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Identifies the bottom-most script which caused the frame to be labelled
    /// as an ad.
    /// </summary>
    public sealed class AdScriptId
    {
        /// <summary>
        /// Script Id of the bottom-most script which caused the frame to be labelled
        /// as an ad.
        ///</summary>
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
        /// <summary>
        /// Id of adScriptId's debugger.
        ///</summary>
        [JsonProperty("debuggerId")]
        public string DebuggerId
        {
            get;
            set;
        }
    }
}