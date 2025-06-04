namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Preload domain to simplify the command interface.
    /// </summary>
    public class PreloadAdapter
    {
        private readonly ChromeSession m_session;
        
        public PreloadAdapter(ChromeSession session)
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
        public async Task<EnableCommandResponse> Enable(EnableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command ?? new EnableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// disable
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Upsert. Currently, it is only emitted when a rule set added.
        /// </summary>
        public void SubscribeToRuleSetUpdatedEvent(Action<RuleSetUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// ruleSetRemoved
        /// </summary>
        public void SubscribeToRuleSetRemovedEvent(Action<RuleSetRemovedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when a preload enabled state is updated.
        /// </summary>
        public void SubscribeToPreloadEnabledStateUpdatedEvent(Action<PreloadEnabledStateUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when a prefetch attempt is updated.
        /// </summary>
        public void SubscribeToPrefetchStatusUpdatedEvent(Action<PrefetchStatusUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Fired when a prerender attempt is updated.
        /// </summary>
        public void SubscribeToPrerenderStatusUpdatedEvent(Action<PrerenderStatusUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Send a list of sources for all preloading attempts in a document.
        /// </summary>
        public void SubscribeToPreloadingAttemptSourcesUpdatedEvent(Action<PreloadingAttemptSourcesUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}