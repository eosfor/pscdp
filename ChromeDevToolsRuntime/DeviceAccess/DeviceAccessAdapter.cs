namespace BaristaLabs.ChromeDevTools.Runtime.DeviceAccess
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the DeviceAccess domain to simplify the command interface.
    /// </summary>
    public class DeviceAccessAdapter
    {
        private readonly ChromeSession m_session;
        
        public DeviceAccessAdapter(ChromeSession session)
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
        /// Enable events in this domain.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disable events in this domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
        /// </summary>
        public async Task<SelectPromptCommandResponse> SelectPrompt(SelectPromptCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SelectPromptCommand, SelectPromptCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
        /// </summary>
        public async Task<CancelPromptCommandResponse> CancelPrompt(CancelPromptCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CancelPromptCommand, CancelPromptCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// A device request opened a user prompt to select a device. Respond with the
        /// selectPrompt or cancelPrompt command.
        /// </summary>
        public void SubscribeToDeviceRequestPromptedEvent(Action<DeviceRequestPromptedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}