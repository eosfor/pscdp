namespace BaristaLabs.ChromeDevTools.Runtime.Extensions
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Extensions domain to simplify the command interface.
    /// </summary>
    public class ExtensionsAdapter
    {
        private readonly ChromeSession m_session;
        
        public ExtensionsAdapter(ChromeSession session)
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
        /// Installs an unpacked extension from the filesystem similar to
        /// --load-extension CLI flags. Returns extension ID once the extension
        /// has been installed. Available if the client is connected using the
        /// --remote-debugging-pipe flag and the --enable-unsafe-extension-debugging
        /// flag is set.
        /// </summary>
        public async Task<LoadUnpackedCommandResponse> LoadUnpacked(LoadUnpackedCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<LoadUnpackedCommand, LoadUnpackedCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Uninstalls an unpacked extension (others not supported) from the profile.
        /// Available if the client is connected using the --remote-debugging-pipe flag
        /// and the --enable-unsafe-extension-debugging.
        /// </summary>
        public async Task<UninstallCommandResponse> Uninstall(UninstallCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UninstallCommand, UninstallCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets data from extension storage in the given `storageArea`. If `keys` is
        /// specified, these are used to filter the result.
        /// </summary>
        public async Task<GetStorageItemsCommandResponse> GetStorageItems(GetStorageItemsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetStorageItemsCommand, GetStorageItemsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes `keys` from extension storage in the given `storageArea`.
        /// </summary>
        public async Task<RemoveStorageItemsCommandResponse> RemoveStorageItems(RemoveStorageItemsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveStorageItemsCommand, RemoveStorageItemsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears extension storage in the given `storageArea`.
        /// </summary>
        public async Task<ClearStorageItemsCommandResponse> ClearStorageItems(ClearStorageItemsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearStorageItemsCommand, ClearStorageItemsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets `values` in extension storage in the given `storageArea`. The provided `values`
        /// will be merged with existing values in the storage area.
        /// </summary>
        public async Task<SetStorageItemsCommandResponse> SetStorageItems(SetStorageItemsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetStorageItemsCommand, SetStorageItemsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}