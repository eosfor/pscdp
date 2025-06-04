namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using Newtonsoft.Json;

    /// <summary>
    /// Changes user settings of the web app identified by its manifestId. If the
    /// app was not installed, this command returns an error. Unset parameters will
    /// be ignored; unrecognized values will cause an error.
    /// 
    /// Unlike the ones defined in the manifest files of the web apps, these
    /// settings are provided by the browser and controlled by the users, they
    /// impact the way the browser handling the web apps.
    /// 
    /// See the comment of each parameter.
    /// </summary>
    public sealed class ChangeAppUserSettingsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "PWA.changeAppUserSettings";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the manifestId
        /// </summary>
        [JsonProperty("manifestId")]
        public string ManifestId
        {
            get;
            set;
        }
        /// <summary>
        /// If user allows the links clicked on by the user in the app's scope, or
        /// extended scope if the manifest has scope extensions and the flags
        /// `DesktopPWAsLinkCapturingWithScopeExtensions` and
        /// `WebAppEnableScopeExtensions` are enabled.
        /// 
        /// Note, the API does not support resetting the linkCapturing to the
        /// initial value, uninstalling and installing the web app again will reset
        /// it.
        /// 
        /// TODO(crbug.com/339453269): Setting this value on ChromeOS is not
        /// supported yet.
        /// </summary>
        [JsonProperty("linkCapturing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? LinkCapturing
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the displayMode
        /// </summary>
        [JsonProperty("displayMode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DisplayMode? DisplayMode
        {
            get;
            set;
        }
    }

    public sealed class ChangeAppUserSettingsCommandResponse : ICommandResponse<ChangeAppUserSettingsCommand>
    {
    }
}