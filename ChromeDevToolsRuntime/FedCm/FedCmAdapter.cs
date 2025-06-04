namespace BaristaLabs.ChromeDevTools.Runtime.FedCm
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the FedCm domain to simplify the command interface.
    /// </summary>
    public class FedCmAdapter
    {
        private readonly ChromeSession m_session;
        
        public FedCmAdapter(ChromeSession session)
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
        /// enable
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// disable
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// selectAccount
        /// </summary>
        public async Task<SelectAccountCommandResponse> SelectAccount(SelectAccountCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SelectAccountCommand, SelectAccountCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// clickDialogButton
        /// </summary>
        public async Task<ClickDialogButtonCommandResponse> ClickDialogButton(ClickDialogButtonCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClickDialogButtonCommand, ClickDialogButtonCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// openUrl
        /// </summary>
        public async Task<OpenUrlCommandResponse> OpenUrl(OpenUrlCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<OpenUrlCommand, OpenUrlCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// dismissDialog
        /// </summary>
        public async Task<DismissDialogCommandResponse> DismissDialog(DismissDialogCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DismissDialogCommand, DismissDialogCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Resets the cooldown time, if any, to allow the next FedCM call to show
        /// a dialog even if one was recently dismissed by the user.
        /// </summary>
        public async Task<ResetCooldownCommandResponse> ResetCooldown(ResetCooldownCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResetCooldownCommand, ResetCooldownCommandResponse>(command ?? new ResetCooldownCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// dialogShown
        /// </summary>
        public void SubscribeToDialogShownEvent(Action<DialogShownEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Triggered when a dialog is closed, either by user action, JS abort,
        /// or a command below.
        /// </summary>
        public void SubscribeToDialogClosedEvent(Action<DialogClosedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}