namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// TODO(https://crbug.com/1384419): revisit the list of PrefetchStatus and
    /// filter out the ones that aren't necessary to the developers.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrefetchStatus
    {
        [EnumMember(Value = "PrefetchAllowed")]
        PrefetchAllowed,
        [EnumMember(Value = "PrefetchFailedIneligibleRedirect")]
        PrefetchFailedIneligibleRedirect,
        [EnumMember(Value = "PrefetchFailedInvalidRedirect")]
        PrefetchFailedInvalidRedirect,
        [EnumMember(Value = "PrefetchFailedMIMENotSupported")]
        PrefetchFailedMIMENotSupported,
        [EnumMember(Value = "PrefetchFailedNetError")]
        PrefetchFailedNetError,
        [EnumMember(Value = "PrefetchFailedNon2XX")]
        PrefetchFailedNon2XX,
        [EnumMember(Value = "PrefetchEvictedAfterBrowsingDataRemoved")]
        PrefetchEvictedAfterBrowsingDataRemoved,
        [EnumMember(Value = "PrefetchEvictedAfterCandidateRemoved")]
        PrefetchEvictedAfterCandidateRemoved,
        [EnumMember(Value = "PrefetchEvictedForNewerPrefetch")]
        PrefetchEvictedForNewerPrefetch,
        [EnumMember(Value = "PrefetchHeldback")]
        PrefetchHeldback,
        [EnumMember(Value = "PrefetchIneligibleRetryAfter")]
        PrefetchIneligibleRetryAfter,
        [EnumMember(Value = "PrefetchIsPrivacyDecoy")]
        PrefetchIsPrivacyDecoy,
        [EnumMember(Value = "PrefetchIsStale")]
        PrefetchIsStale,
        [EnumMember(Value = "PrefetchNotEligibleBrowserContextOffTheRecord")]
        PrefetchNotEligibleBrowserContextOffTheRecord,
        [EnumMember(Value = "PrefetchNotEligibleDataSaverEnabled")]
        PrefetchNotEligibleDataSaverEnabled,
        [EnumMember(Value = "PrefetchNotEligibleExistingProxy")]
        PrefetchNotEligibleExistingProxy,
        [EnumMember(Value = "PrefetchNotEligibleHostIsNonUnique")]
        PrefetchNotEligibleHostIsNonUnique,
        [EnumMember(Value = "PrefetchNotEligibleNonDefaultStoragePartition")]
        PrefetchNotEligibleNonDefaultStoragePartition,
        [EnumMember(Value = "PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy")]
        PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy,
        [EnumMember(Value = "PrefetchNotEligibleSchemeIsNotHttps")]
        PrefetchNotEligibleSchemeIsNotHttps,
        [EnumMember(Value = "PrefetchNotEligibleUserHasCookies")]
        PrefetchNotEligibleUserHasCookies,
        [EnumMember(Value = "PrefetchNotEligibleUserHasServiceWorker")]
        PrefetchNotEligibleUserHasServiceWorker,
        [EnumMember(Value = "PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler")]
        PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler,
        [EnumMember(Value = "PrefetchNotEligibleRedirectFromServiceWorker")]
        PrefetchNotEligibleRedirectFromServiceWorker,
        [EnumMember(Value = "PrefetchNotEligibleRedirectToServiceWorker")]
        PrefetchNotEligibleRedirectToServiceWorker,
        [EnumMember(Value = "PrefetchNotEligibleBatterySaverEnabled")]
        PrefetchNotEligibleBatterySaverEnabled,
        [EnumMember(Value = "PrefetchNotEligiblePreloadingDisabled")]
        PrefetchNotEligiblePreloadingDisabled,
        [EnumMember(Value = "PrefetchNotFinishedInTime")]
        PrefetchNotFinishedInTime,
        [EnumMember(Value = "PrefetchNotStarted")]
        PrefetchNotStarted,
        [EnumMember(Value = "PrefetchNotUsedCookiesChanged")]
        PrefetchNotUsedCookiesChanged,
        [EnumMember(Value = "PrefetchProxyNotAvailable")]
        PrefetchProxyNotAvailable,
        [EnumMember(Value = "PrefetchResponseUsed")]
        PrefetchResponseUsed,
        [EnumMember(Value = "PrefetchSuccessfulButNotUsed")]
        PrefetchSuccessfulButNotUsed,
        [EnumMember(Value = "PrefetchNotUsedProbeFailed")]
        PrefetchNotUsedProbeFailed,
    }
}