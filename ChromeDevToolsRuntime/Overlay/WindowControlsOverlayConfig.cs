namespace BaristaLabs.ChromeDevTools.Runtime.Overlay
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configuration for Window Controls Overlay
    /// </summary>
    public sealed class WindowControlsOverlayConfig
    {
        /// <summary>
        /// Whether the title bar CSS should be shown when emulating the Window Controls Overlay.
        ///</summary>
        [JsonProperty("showCSS")]
        public bool ShowCSS
        {
            get;
            set;
        }
        /// <summary>
        /// Selected platforms to show the overlay.
        ///</summary>
        [JsonProperty("selectedPlatform")]
        public string SelectedPlatform
        {
            get;
            set;
        }
        /// <summary>
        /// The theme color defined in app manifest.
        ///</summary>
        [JsonProperty("themeColor")]
        public string ThemeColor
        {
            get;
            set;
        }
    }
}