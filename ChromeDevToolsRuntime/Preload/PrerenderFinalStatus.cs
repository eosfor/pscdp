namespace BaristaLabs.ChromeDevTools.Runtime.Preload
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// List of FinalStatus reasons for Prerender2.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrerenderFinalStatus
    {
        [EnumMember(Value = "Activated")]
        Activated,
        [EnumMember(Value = "Destroyed")]
        Destroyed,
        [EnumMember(Value = "LowEndDevice")]
        LowEndDevice,
        [EnumMember(Value = "InvalidSchemeRedirect")]
        InvalidSchemeRedirect,
        [EnumMember(Value = "InvalidSchemeNavigation")]
        InvalidSchemeNavigation,
        [EnumMember(Value = "NavigationRequestBlockedByCsp")]
        NavigationRequestBlockedByCsp,
        [EnumMember(Value = "MojoBinderPolicy")]
        MojoBinderPolicy,
        [EnumMember(Value = "RendererProcessCrashed")]
        RendererProcessCrashed,
        [EnumMember(Value = "RendererProcessKilled")]
        RendererProcessKilled,
        [EnumMember(Value = "Download")]
        Download,
        [EnumMember(Value = "TriggerDestroyed")]
        TriggerDestroyed,
        [EnumMember(Value = "NavigationNotCommitted")]
        NavigationNotCommitted,
        [EnumMember(Value = "NavigationBadHttpStatus")]
        NavigationBadHttpStatus,
        [EnumMember(Value = "ClientCertRequested")]
        ClientCertRequested,
        [EnumMember(Value = "NavigationRequestNetworkError")]
        NavigationRequestNetworkError,
        [EnumMember(Value = "CancelAllHostsForTesting")]
        CancelAllHostsForTesting,
        [EnumMember(Value = "DidFailLoad")]
        DidFailLoad,
        [EnumMember(Value = "Stop")]
        Stop,
        [EnumMember(Value = "SslCertificateError")]
        SslCertificateError,
        [EnumMember(Value = "LoginAuthRequested")]
        LoginAuthRequested,
        [EnumMember(Value = "UaChangeRequiresReload")]
        UaChangeRequiresReload,
        [EnumMember(Value = "BlockedByClient")]
        BlockedByClient,
        [EnumMember(Value = "AudioOutputDeviceRequested")]
        AudioOutputDeviceRequested,
        [EnumMember(Value = "MixedContent")]
        MixedContent,
        [EnumMember(Value = "TriggerBackgrounded")]
        TriggerBackgrounded,
        [EnumMember(Value = "MemoryLimitExceeded")]
        MemoryLimitExceeded,
        [EnumMember(Value = "DataSaverEnabled")]
        DataSaverEnabled,
        [EnumMember(Value = "TriggerUrlHasEffectiveUrl")]
        TriggerUrlHasEffectiveUrl,
        [EnumMember(Value = "ActivatedBeforeStarted")]
        ActivatedBeforeStarted,
        [EnumMember(Value = "InactivePageRestriction")]
        InactivePageRestriction,
        [EnumMember(Value = "StartFailed")]
        StartFailed,
        [EnumMember(Value = "TimeoutBackgrounded")]
        TimeoutBackgrounded,
        [EnumMember(Value = "CrossSiteRedirectInInitialNavigation")]
        CrossSiteRedirectInInitialNavigation,
        [EnumMember(Value = "CrossSiteNavigationInInitialNavigation")]
        CrossSiteNavigationInInitialNavigation,
        [EnumMember(Value = "SameSiteCrossOriginRedirectNotOptInInInitialNavigation")]
        SameSiteCrossOriginRedirectNotOptInInInitialNavigation,
        [EnumMember(Value = "SameSiteCrossOriginNavigationNotOptInInInitialNavigation")]
        SameSiteCrossOriginNavigationNotOptInInInitialNavigation,
        [EnumMember(Value = "ActivationNavigationParameterMismatch")]
        ActivationNavigationParameterMismatch,
        [EnumMember(Value = "ActivatedInBackground")]
        ActivatedInBackground,
        [EnumMember(Value = "EmbedderHostDisallowed")]
        EmbedderHostDisallowed,
        [EnumMember(Value = "ActivationNavigationDestroyedBeforeSuccess")]
        ActivationNavigationDestroyedBeforeSuccess,
        [EnumMember(Value = "TabClosedByUserGesture")]
        TabClosedByUserGesture,
        [EnumMember(Value = "TabClosedWithoutUserGesture")]
        TabClosedWithoutUserGesture,
        [EnumMember(Value = "PrimaryMainFrameRendererProcessCrashed")]
        PrimaryMainFrameRendererProcessCrashed,
        [EnumMember(Value = "PrimaryMainFrameRendererProcessKilled")]
        PrimaryMainFrameRendererProcessKilled,
        [EnumMember(Value = "ActivationFramePolicyNotCompatible")]
        ActivationFramePolicyNotCompatible,
        [EnumMember(Value = "PreloadingDisabled")]
        PreloadingDisabled,
        [EnumMember(Value = "BatterySaverEnabled")]
        BatterySaverEnabled,
        [EnumMember(Value = "ActivatedDuringMainFrameNavigation")]
        ActivatedDuringMainFrameNavigation,
        [EnumMember(Value = "PreloadingUnsupportedByWebContents")]
        PreloadingUnsupportedByWebContents,
        [EnumMember(Value = "CrossSiteRedirectInMainFrameNavigation")]
        CrossSiteRedirectInMainFrameNavigation,
        [EnumMember(Value = "CrossSiteNavigationInMainFrameNavigation")]
        CrossSiteNavigationInMainFrameNavigation,
        [EnumMember(Value = "SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation")]
        SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation,
        [EnumMember(Value = "SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation")]
        SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation,
        [EnumMember(Value = "MemoryPressureOnTrigger")]
        MemoryPressureOnTrigger,
        [EnumMember(Value = "MemoryPressureAfterTriggered")]
        MemoryPressureAfterTriggered,
        [EnumMember(Value = "PrerenderingDisabledByDevTools")]
        PrerenderingDisabledByDevTools,
        [EnumMember(Value = "SpeculationRuleRemoved")]
        SpeculationRuleRemoved,
        [EnumMember(Value = "ActivatedWithAuxiliaryBrowsingContexts")]
        ActivatedWithAuxiliaryBrowsingContexts,
        [EnumMember(Value = "MaxNumOfRunningEagerPrerendersExceeded")]
        MaxNumOfRunningEagerPrerendersExceeded,
        [EnumMember(Value = "MaxNumOfRunningNonEagerPrerendersExceeded")]
        MaxNumOfRunningNonEagerPrerendersExceeded,
        [EnumMember(Value = "MaxNumOfRunningEmbedderPrerendersExceeded")]
        MaxNumOfRunningEmbedderPrerendersExceeded,
        [EnumMember(Value = "PrerenderingUrlHasEffectiveUrl")]
        PrerenderingUrlHasEffectiveUrl,
        [EnumMember(Value = "RedirectedPrerenderingUrlHasEffectiveUrl")]
        RedirectedPrerenderingUrlHasEffectiveUrl,
        [EnumMember(Value = "ActivationUrlHasEffectiveUrl")]
        ActivationUrlHasEffectiveUrl,
        [EnumMember(Value = "JavaScriptInterfaceAdded")]
        JavaScriptInterfaceAdded,
        [EnumMember(Value = "JavaScriptInterfaceRemoved")]
        JavaScriptInterfaceRemoved,
        [EnumMember(Value = "AllPrerenderingCanceled")]
        AllPrerenderingCanceled,
        [EnumMember(Value = "WindowClosed")]
        WindowClosed,
        [EnumMember(Value = "SlowNetwork")]
        SlowNetwork,
        [EnumMember(Value = "OtherPrerenderedPageActivated")]
        OtherPrerenderedPageActivated,
        [EnumMember(Value = "V8OptimizerDisabled")]
        V8OptimizerDisabled,
        [EnumMember(Value = "PrerenderFailedDuringPrefetch")]
        PrerenderFailedDuringPrefetch,
        [EnumMember(Value = "BrowsingDataRemoved")]
        BrowsingDataRemoved,
    }
}