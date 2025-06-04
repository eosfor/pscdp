namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Storage domain to simplify the command interface.
    /// </summary>
    public class StorageAdapter
    {
        private readonly ChromeSession m_session;
        
        public StorageAdapter(ChromeSession session)
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
        /// Returns a storage key given a frame id.
        /// </summary>
        public async Task<GetStorageKeyForFrameCommandResponse> GetStorageKeyForFrame(GetStorageKeyForFrameCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetStorageKeyForFrameCommand, GetStorageKeyForFrameCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears storage for origin.
        /// </summary>
        public async Task<ClearDataForOriginCommandResponse> ClearDataForOrigin(ClearDataForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDataForOriginCommand, ClearDataForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears storage for storage key.
        /// </summary>
        public async Task<ClearDataForStorageKeyCommandResponse> ClearDataForStorageKey(ClearDataForStorageKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDataForStorageKeyCommand, ClearDataForStorageKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns all browser cookies.
        /// </summary>
        public async Task<GetCookiesCommandResponse> GetCookies(GetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetCookiesCommand, GetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets given cookies.
        /// </summary>
        public async Task<SetCookiesCommandResponse> SetCookies(SetCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCookiesCommand, SetCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears cookies.
        /// </summary>
        public async Task<ClearCookiesCommandResponse> ClearCookies(ClearCookiesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearCookiesCommand, ClearCookiesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns usage and quota in bytes.
        /// </summary>
        public async Task<GetUsageAndQuotaCommandResponse> GetUsageAndQuota(GetUsageAndQuotaCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetUsageAndQuotaCommand, GetUsageAndQuotaCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Override quota for the specified origin
        /// </summary>
        public async Task<OverrideQuotaForOriginCommandResponse> OverrideQuotaForOrigin(OverrideQuotaForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<OverrideQuotaForOriginCommand, OverrideQuotaForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers origin to be notified when an update occurs to its cache storage list.
        /// </summary>
        public async Task<TrackCacheStorageForOriginCommandResponse> TrackCacheStorageForOrigin(TrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackCacheStorageForOriginCommand, TrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers storage key to be notified when an update occurs to its cache storage list.
        /// </summary>
        public async Task<TrackCacheStorageForStorageKeyCommandResponse> TrackCacheStorageForStorageKey(TrackCacheStorageForStorageKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackCacheStorageForStorageKeyCommand, TrackCacheStorageForStorageKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers origin to be notified when an update occurs to its IndexedDB.
        /// </summary>
        public async Task<TrackIndexedDBForOriginCommandResponse> TrackIndexedDBForOrigin(TrackIndexedDBForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackIndexedDBForOriginCommand, TrackIndexedDBForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Registers storage key to be notified when an update occurs to its IndexedDB.
        /// </summary>
        public async Task<TrackIndexedDBForStorageKeyCommandResponse> TrackIndexedDBForStorageKey(TrackIndexedDBForStorageKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<TrackIndexedDBForStorageKeyCommand, TrackIndexedDBForStorageKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters origin from receiving notifications for cache storage.
        /// </summary>
        public async Task<UntrackCacheStorageForOriginCommandResponse> UntrackCacheStorageForOrigin(UntrackCacheStorageForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackCacheStorageForOriginCommand, UntrackCacheStorageForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters storage key from receiving notifications for cache storage.
        /// </summary>
        public async Task<UntrackCacheStorageForStorageKeyCommandResponse> UntrackCacheStorageForStorageKey(UntrackCacheStorageForStorageKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackCacheStorageForStorageKeyCommand, UntrackCacheStorageForStorageKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters origin from receiving notifications for IndexedDB.
        /// </summary>
        public async Task<UntrackIndexedDBForOriginCommandResponse> UntrackIndexedDBForOrigin(UntrackIndexedDBForOriginCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackIndexedDBForOriginCommand, UntrackIndexedDBForOriginCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Unregisters storage key from receiving notifications for IndexedDB.
        /// </summary>
        public async Task<UntrackIndexedDBForStorageKeyCommandResponse> UntrackIndexedDBForStorageKey(UntrackIndexedDBForStorageKeyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<UntrackIndexedDBForStorageKeyCommand, UntrackIndexedDBForStorageKeyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the number of stored Trust Tokens per issuer for the
        /// current browsing context.
        /// </summary>
        public async Task<GetTrustTokensCommandResponse> GetTrustTokens(GetTrustTokensCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetTrustTokensCommand, GetTrustTokensCommandResponse>(command ?? new GetTrustTokensCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes all Trust Tokens issued by the provided issuerOrigin.
        /// Leaves other stored data, including the issuer's Redemption Records, intact.
        /// </summary>
        public async Task<ClearTrustTokensCommandResponse> ClearTrustTokens(ClearTrustTokensCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearTrustTokensCommand, ClearTrustTokensCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets details for a named interest group.
        /// </summary>
        public async Task<GetInterestGroupDetailsCommandResponse> GetInterestGroupDetails(GetInterestGroupDetailsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetInterestGroupDetailsCommand, GetInterestGroupDetailsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables/Disables issuing of interestGroupAccessed events.
        /// </summary>
        public async Task<SetInterestGroupTrackingCommandResponse> SetInterestGroupTracking(SetInterestGroupTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInterestGroupTrackingCommand, SetInterestGroupTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables/Disables issuing of interestGroupAuctionEventOccurred and
        /// interestGroupAuctionNetworkRequestCreated.
        /// </summary>
        public async Task<SetInterestGroupAuctionTrackingCommandResponse> SetInterestGroupAuctionTracking(SetInterestGroupAuctionTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetInterestGroupAuctionTrackingCommand, SetInterestGroupAuctionTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets metadata for an origin's shared storage.
        /// </summary>
        public async Task<GetSharedStorageMetadataCommandResponse> GetSharedStorageMetadata(GetSharedStorageMetadataCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSharedStorageMetadataCommand, GetSharedStorageMetadataCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Gets the entries in an given origin's shared storage.
        /// </summary>
        public async Task<GetSharedStorageEntriesCommandResponse> GetSharedStorageEntries(GetSharedStorageEntriesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetSharedStorageEntriesCommand, GetSharedStorageEntriesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets entry with `key` and `value` for a given origin's shared storage.
        /// </summary>
        public async Task<SetSharedStorageEntryCommandResponse> SetSharedStorageEntry(SetSharedStorageEntryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSharedStorageEntryCommand, SetSharedStorageEntryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes entry for `key` (if it exists) for a given origin's shared storage.
        /// </summary>
        public async Task<DeleteSharedStorageEntryCommandResponse> DeleteSharedStorageEntry(DeleteSharedStorageEntryCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteSharedStorageEntryCommand, DeleteSharedStorageEntryCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears all entries for a given origin's shared storage.
        /// </summary>
        public async Task<ClearSharedStorageEntriesCommandResponse> ClearSharedStorageEntries(ClearSharedStorageEntriesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearSharedStorageEntriesCommand, ClearSharedStorageEntriesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Resets the budget for `ownerOrigin` by clearing all budget withdrawals.
        /// </summary>
        public async Task<ResetSharedStorageBudgetCommandResponse> ResetSharedStorageBudget(ResetSharedStorageBudgetCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResetSharedStorageBudgetCommand, ResetSharedStorageBudgetCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables/disables issuing of sharedStorageAccessed events.
        /// </summary>
        public async Task<SetSharedStorageTrackingCommandResponse> SetSharedStorageTracking(SetSharedStorageTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSharedStorageTrackingCommand, SetSharedStorageTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Set tracking for a storage key's buckets.
        /// </summary>
        public async Task<SetStorageBucketTrackingCommandResponse> SetStorageBucketTracking(SetStorageBucketTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetStorageBucketTrackingCommand, SetStorageBucketTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes the Storage Bucket with the given storage key and bucket name.
        /// </summary>
        public async Task<DeleteStorageBucketCommandResponse> DeleteStorageBucket(DeleteStorageBucketCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DeleteStorageBucketCommand, DeleteStorageBucketCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Deletes state for sites identified as potential bounce trackers, immediately.
        /// </summary>
        public async Task<RunBounceTrackingMitigationsCommandResponse> RunBounceTrackingMitigations(RunBounceTrackingMitigationsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RunBounceTrackingMitigationsCommand, RunBounceTrackingMitigationsCommandResponse>(command ?? new RunBounceTrackingMitigationsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// https://wicg.github.io/attribution-reporting-api/
        /// </summary>
        public async Task<SetAttributionReportingLocalTestingModeCommandResponse> SetAttributionReportingLocalTestingMode(SetAttributionReportingLocalTestingModeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAttributionReportingLocalTestingModeCommand, SetAttributionReportingLocalTestingModeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables/disables issuing of Attribution Reporting events.
        /// </summary>
        public async Task<SetAttributionReportingTrackingCommandResponse> SetAttributionReportingTracking(SetAttributionReportingTrackingCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAttributionReportingTrackingCommand, SetAttributionReportingTrackingCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sends all pending Attribution Reports immediately, regardless of their
        /// scheduled report time.
        /// </summary>
        public async Task<SendPendingAttributionReportsCommandResponse> SendPendingAttributionReports(SendPendingAttributionReportsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SendPendingAttributionReportsCommand, SendPendingAttributionReportsCommandResponse>(command ?? new SendPendingAttributionReportsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the effective Related Website Sets in use by this profile for the browser
        /// session. The effective Related Website Sets will not change during a browser session.
        /// </summary>
        public async Task<GetRelatedWebsiteSetsCommandResponse> GetRelatedWebsiteSets(GetRelatedWebsiteSetsCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetRelatedWebsiteSetsCommand, GetRelatedWebsiteSetsCommandResponse>(command ?? new GetRelatedWebsiteSetsCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Returns the list of URLs from a page and its embedded resources that match
        /// existing grace period URL pattern rules.
        /// https://developers.google.com/privacy-sandbox/cookies/temporary-exceptions/grace-period
        /// </summary>
        public async Task<GetAffectedUrlsForThirdPartyCookieMetadataCommandResponse> GetAffectedUrlsForThirdPartyCookieMetadata(GetAffectedUrlsForThirdPartyCookieMetadataCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetAffectedUrlsForThirdPartyCookieMetadataCommand, GetAffectedUrlsForThirdPartyCookieMetadataCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setProtectedAudienceKAnonymity
        /// </summary>
        public async Task<SetProtectedAudienceKAnonymityCommandResponse> SetProtectedAudienceKAnonymity(SetProtectedAudienceKAnonymityCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetProtectedAudienceKAnonymityCommand, SetProtectedAudienceKAnonymityCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// A cache's contents have been modified.
        /// </summary>
        public void SubscribeToCacheStorageContentUpdatedEvent(Action<CacheStorageContentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// A cache has been added/deleted.
        /// </summary>
        public void SubscribeToCacheStorageListUpdatedEvent(Action<CacheStorageListUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// The origin's IndexedDB object store has been modified.
        /// </summary>
        public void SubscribeToIndexedDBContentUpdatedEvent(Action<IndexedDBContentUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// The origin's IndexedDB database list has been modified.
        /// </summary>
        public void SubscribeToIndexedDBListUpdatedEvent(Action<IndexedDBListUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// One of the interest groups was accessed. Note that these events are global
        /// to all targets sharing an interest group store.
        /// </summary>
        public void SubscribeToInterestGroupAccessedEvent(Action<InterestGroupAccessedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// An auction involving interest groups is taking place. These events are
        /// target-specific.
        /// </summary>
        public void SubscribeToInterestGroupAuctionEventOccurredEvent(Action<InterestGroupAuctionEventOccurredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Specifies which auctions a particular network fetch may be related to, and
        /// in what role. Note that it is not ordered with respect to
        /// Network.requestWillBeSent (but will happen before loadingFinished
        /// loadingFailed).
        /// </summary>
        public void SubscribeToInterestGroupAuctionNetworkRequestCreatedEvent(Action<InterestGroupAuctionNetworkRequestCreatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Shared storage was accessed by the associated page.
        /// The following parameters are included in all events.
        /// </summary>
        public void SubscribeToSharedStorageAccessedEvent(Action<SharedStorageAccessedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// A shared storage run or selectURL operation finished its execution.
        /// The following parameters are included in all events.
        /// </summary>
        public void SubscribeToSharedStorageWorkletOperationExecutionFinishedEvent(Action<SharedStorageWorkletOperationExecutionFinishedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// storageBucketCreatedOrUpdated
        /// </summary>
        public void SubscribeToStorageBucketCreatedOrUpdatedEvent(Action<StorageBucketCreatedOrUpdatedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// storageBucketDeleted
        /// </summary>
        public void SubscribeToStorageBucketDeletedEvent(Action<StorageBucketDeletedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// attributionReportingSourceRegistered
        /// </summary>
        public void SubscribeToAttributionReportingSourceRegisteredEvent(Action<AttributionReportingSourceRegisteredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// attributionReportingTriggerRegistered
        /// </summary>
        public void SubscribeToAttributionReportingTriggerRegisteredEvent(Action<AttributionReportingTriggerRegisteredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// attributionReportingReportSent
        /// </summary>
        public void SubscribeToAttributionReportingReportSentEvent(Action<AttributionReportingReportSentEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}