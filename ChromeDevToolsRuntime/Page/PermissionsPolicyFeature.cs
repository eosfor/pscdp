namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// All Permissions Policy features. This enum should match the one defined
    /// in services/network/public/cpp/permissions_policy/permissions_policy_features.json5.
    /// LINT.IfChange(PermissionsPolicyFeature)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionsPolicyFeature
    {
        [EnumMember(Value = "accelerometer")]
        Accelerometer,
        [EnumMember(Value = "all-screens-capture")]
        AllScreensCapture,
        [EnumMember(Value = "ambient-light-sensor")]
        AmbientLightSensor,
        [EnumMember(Value = "attribution-reporting")]
        AttributionReporting,
        [EnumMember(Value = "autoplay")]
        Autoplay,
        [EnumMember(Value = "bluetooth")]
        Bluetooth,
        [EnumMember(Value = "browsing-topics")]
        BrowsingTopics,
        [EnumMember(Value = "camera")]
        Camera,
        [EnumMember(Value = "captured-surface-control")]
        CapturedSurfaceControl,
        [EnumMember(Value = "ch-dpr")]
        ChDpr,
        [EnumMember(Value = "ch-device-memory")]
        ChDeviceMemory,
        [EnumMember(Value = "ch-downlink")]
        ChDownlink,
        [EnumMember(Value = "ch-ect")]
        ChEct,
        [EnumMember(Value = "ch-prefers-color-scheme")]
        ChPrefersColorScheme,
        [EnumMember(Value = "ch-prefers-reduced-motion")]
        ChPrefersReducedMotion,
        [EnumMember(Value = "ch-prefers-reduced-transparency")]
        ChPrefersReducedTransparency,
        [EnumMember(Value = "ch-rtt")]
        ChRtt,
        [EnumMember(Value = "ch-save-data")]
        ChSaveData,
        [EnumMember(Value = "ch-ua")]
        ChUa,
        [EnumMember(Value = "ch-ua-arch")]
        ChUaArch,
        [EnumMember(Value = "ch-ua-bitness")]
        ChUaBitness,
        [EnumMember(Value = "ch-ua-high-entropy-values")]
        ChUaHighEntropyValues,
        [EnumMember(Value = "ch-ua-platform")]
        ChUaPlatform,
        [EnumMember(Value = "ch-ua-model")]
        ChUaModel,
        [EnumMember(Value = "ch-ua-mobile")]
        ChUaMobile,
        [EnumMember(Value = "ch-ua-form-factors")]
        ChUaFormFactors,
        [EnumMember(Value = "ch-ua-full-version")]
        ChUaFullVersion,
        [EnumMember(Value = "ch-ua-full-version-list")]
        ChUaFullVersionList,
        [EnumMember(Value = "ch-ua-platform-version")]
        ChUaPlatformVersion,
        [EnumMember(Value = "ch-ua-wow64")]
        ChUaWow64,
        [EnumMember(Value = "ch-viewport-height")]
        ChViewportHeight,
        [EnumMember(Value = "ch-viewport-width")]
        ChViewportWidth,
        [EnumMember(Value = "ch-width")]
        ChWidth,
        [EnumMember(Value = "clipboard-read")]
        ClipboardRead,
        [EnumMember(Value = "clipboard-write")]
        ClipboardWrite,
        [EnumMember(Value = "compute-pressure")]
        ComputePressure,
        [EnumMember(Value = "controlled-frame")]
        ControlledFrame,
        [EnumMember(Value = "cross-origin-isolated")]
        CrossOriginIsolated,
        [EnumMember(Value = "deferred-fetch")]
        DeferredFetch,
        [EnumMember(Value = "deferred-fetch-minimal")]
        DeferredFetchMinimal,
        [EnumMember(Value = "device-attributes")]
        DeviceAttributes,
        [EnumMember(Value = "digital-credentials-get")]
        DigitalCredentialsGet,
        [EnumMember(Value = "direct-sockets")]
        DirectSockets,
        [EnumMember(Value = "direct-sockets-private")]
        DirectSocketsPrivate,
        [EnumMember(Value = "display-capture")]
        DisplayCapture,
        [EnumMember(Value = "document-domain")]
        DocumentDomain,
        [EnumMember(Value = "encrypted-media")]
        EncryptedMedia,
        [EnumMember(Value = "execution-while-out-of-viewport")]
        ExecutionWhileOutOfViewport,
        [EnumMember(Value = "execution-while-not-rendered")]
        ExecutionWhileNotRendered,
        [EnumMember(Value = "fenced-unpartitioned-storage-read")]
        FencedUnpartitionedStorageRead,
        [EnumMember(Value = "focus-without-user-activation")]
        FocusWithoutUserActivation,
        [EnumMember(Value = "fullscreen")]
        Fullscreen,
        [EnumMember(Value = "frobulate")]
        Frobulate,
        [EnumMember(Value = "gamepad")]
        Gamepad,
        [EnumMember(Value = "geolocation")]
        Geolocation,
        [EnumMember(Value = "gyroscope")]
        Gyroscope,
        [EnumMember(Value = "hid")]
        Hid,
        [EnumMember(Value = "identity-credentials-get")]
        IdentityCredentialsGet,
        [EnumMember(Value = "idle-detection")]
        IdleDetection,
        [EnumMember(Value = "interest-cohort")]
        InterestCohort,
        [EnumMember(Value = "join-ad-interest-group")]
        JoinAdInterestGroup,
        [EnumMember(Value = "keyboard-map")]
        KeyboardMap,
        [EnumMember(Value = "language-detector")]
        LanguageDetector,
        [EnumMember(Value = "local-fonts")]
        LocalFonts,
        [EnumMember(Value = "local-network-access")]
        LocalNetworkAccess,
        [EnumMember(Value = "magnetometer")]
        Magnetometer,
        [EnumMember(Value = "media-playback-while-not-visible")]
        MediaPlaybackWhileNotVisible,
        [EnumMember(Value = "microphone")]
        Microphone,
        [EnumMember(Value = "midi")]
        Midi,
        [EnumMember(Value = "on-device-speech-recognition")]
        OnDeviceSpeechRecognition,
        [EnumMember(Value = "otp-credentials")]
        OtpCredentials,
        [EnumMember(Value = "payment")]
        Payment,
        [EnumMember(Value = "picture-in-picture")]
        PictureInPicture,
        [EnumMember(Value = "popins")]
        Popins,
        [EnumMember(Value = "private-aggregation")]
        PrivateAggregation,
        [EnumMember(Value = "private-state-token-issuance")]
        PrivateStateTokenIssuance,
        [EnumMember(Value = "private-state-token-redemption")]
        PrivateStateTokenRedemption,
        [EnumMember(Value = "publickey-credentials-create")]
        PublickeyCredentialsCreate,
        [EnumMember(Value = "publickey-credentials-get")]
        PublickeyCredentialsGet,
        [EnumMember(Value = "record-ad-auction-events")]
        RecordAdAuctionEvents,
        [EnumMember(Value = "rewriter")]
        Rewriter,
        [EnumMember(Value = "run-ad-auction")]
        RunAdAuction,
        [EnumMember(Value = "screen-wake-lock")]
        ScreenWakeLock,
        [EnumMember(Value = "serial")]
        Serial,
        [EnumMember(Value = "shared-autofill")]
        SharedAutofill,
        [EnumMember(Value = "shared-storage")]
        SharedStorage,
        [EnumMember(Value = "shared-storage-select-url")]
        SharedStorageSelectUrl,
        [EnumMember(Value = "smart-card")]
        SmartCard,
        [EnumMember(Value = "speaker-selection")]
        SpeakerSelection,
        [EnumMember(Value = "storage-access")]
        StorageAccess,
        [EnumMember(Value = "sub-apps")]
        SubApps,
        [EnumMember(Value = "summarizer")]
        Summarizer,
        [EnumMember(Value = "sync-xhr")]
        SyncXhr,
        [EnumMember(Value = "translator")]
        Translator,
        [EnumMember(Value = "unload")]
        Unload,
        [EnumMember(Value = "usb")]
        Usb,
        [EnumMember(Value = "usb-unrestricted")]
        UsbUnrestricted,
        [EnumMember(Value = "vertical-scroll")]
        VerticalScroll,
        [EnumMember(Value = "web-app-installation")]
        WebAppInstallation,
        [EnumMember(Value = "web-printing")]
        WebPrinting,
        [EnumMember(Value = "web-share")]
        WebShare,
        [EnumMember(Value = "window-management")]
        WindowManagement,
        [EnumMember(Value = "writer")]
        Writer,
        [EnumMember(Value = "xr-spatial-tracking")]
        XrSpatialTracking,
    }
}