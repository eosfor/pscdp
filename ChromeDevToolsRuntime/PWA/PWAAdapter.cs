namespace BaristaLabs.ChromeDevTools.Runtime.PWA
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the PWA domain to simplify the command interface.
    /// </summary>
    public class PWAAdapter
    {
        private readonly ChromeSession m_session;
        
        public PWAAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Returns the following OS state for the given manifest id.
        /// </summary>
        public async Task<GetOsAppStateCommandResponse> GetOsAppState(GetOsAppStateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetOsAppStateCommand, GetOsAppStateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Installs the given manifest identity, optionally using the given install_url
        /// or IWA bundle location.
        /// 
        /// TODO(crbug.com/337872319) Support IWA to meet the following specific
        /// requirement.
        /// IWA-specific install description: If the manifest_id is isolated-app://,
        /// install_url_or_bundle_url is required, and can be either an http(s) URL or
        /// file:// URL pointing to a signed web bundle (.swbn). The .swbn file's
        /// signing key must correspond to manifest_id. If Chrome is not in IWA dev
        /// mode, the installation will fail, regardless of the state of the allowlist.
        /// </summary>
        public async Task<InstallCommandResponse> Install(InstallCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<InstallCommand, InstallCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Uninstalls the given manifest_id and closes any opened app windows.
        /// </summary>
        public async Task<UninstallCommandResponse> Uninstall(UninstallCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UninstallCommand, UninstallCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Launches the installed web app, or an url in the same web app instead of the
        /// default start url if it is provided. Returns a page Target.TargetID which
        /// can be used to attach to via Target.attachToTarget or similar APIs.
        /// </summary>
        public async Task<LaunchCommandResponse> Launch(LaunchCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<LaunchCommand, LaunchCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Opens one or more local files from an installed web app identified by its
        /// manifestId. The web app needs to have file handlers registered to process
        /// the files. The API returns one or more page Target.TargetIDs which can be
        /// used to attach to via Target.attachToTarget or similar APIs.
        /// If some files in the parameters cannot be handled by the web app, they will
        /// be ignored. If none of the files can be handled, this API returns an error.
        /// If no files are provided as the parameter, this API also returns an error.
        /// 
        /// According to the definition of the file handlers in the manifest file, one
        /// Target.TargetID may represent a page handling one or more files. The order
        /// of the returned Target.TargetIDs is not guaranteed.
        /// 
        /// TODO(crbug.com/339454034): Check the existences of the input files.
        /// </summary>
        public async Task<LaunchFilesInAppCommandResponse> LaunchFilesInApp(LaunchFilesInAppCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<LaunchFilesInAppCommand, LaunchFilesInAppCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Opens the current page in its web app identified by the manifest id, needs
        /// to be called on a page target. This function returns immediately without
        /// waiting for the app to finish loading.
        /// </summary>
        public async Task<OpenCurrentPageInAppCommandResponse> OpenCurrentPageInApp(OpenCurrentPageInAppCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<OpenCurrentPageInAppCommand, OpenCurrentPageInAppCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
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
        public async Task<ChangeAppUserSettingsCommandResponse> ChangeAppUserSettings(ChangeAppUserSettingsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ChangeAppUserSettingsCommand, ChangeAppUserSettingsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}