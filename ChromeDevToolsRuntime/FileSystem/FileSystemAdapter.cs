namespace BaristaLabs.ChromeDevTools.Runtime.FileSystem
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the FileSystem domain to simplify the command interface.
    /// </summary>
    public class FileSystemAdapter
    {
        private readonly ChromeSession m_session;
        
        public FileSystemAdapter(ChromeSession session)
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
        /// getDirectory
        /// </summary>
        public async Task<GetDirectoryCommandResponse> GetDirectory(GetDirectoryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDirectoryCommand, GetDirectoryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

    }
}