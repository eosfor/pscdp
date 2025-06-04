namespace BaristaLabs.ChromeDevTools.Runtime.Browser
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// PermissionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PermissionType
    {
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "audioCapture")]
        AudioCapture,
        [EnumMember(Value = "automaticFullscreen")]
        AutomaticFullscreen,
        [EnumMember(Value = "backgroundFetch")]
        BackgroundFetch,
        [EnumMember(Value = "backgroundSync")]
        BackgroundSync,
        [EnumMember(Value = "cameraPanTiltZoom")]
        CameraPanTiltZoom,
        [EnumMember(Value = "capturedSurfaceControl")]
        CapturedSurfaceControl,
        [EnumMember(Value = "clipboardReadWrite")]
        ClipboardReadWrite,
        [EnumMember(Value = "clipboardSanitizedWrite")]
        ClipboardSanitizedWrite,
        [EnumMember(Value = "displayCapture")]
        DisplayCapture,
        [EnumMember(Value = "durableStorage")]
        DurableStorage,
        [EnumMember(Value = "geolocation")]
        Geolocation,
        [EnumMember(Value = "handTracking")]
        HandTracking,
        [EnumMember(Value = "idleDetection")]
        IdleDetection,
        [EnumMember(Value = "keyboardLock")]
        KeyboardLock,
        [EnumMember(Value = "localFonts")]
        LocalFonts,
        [EnumMember(Value = "localNetworkAccess")]
        LocalNetworkAccess,
        [EnumMember(Value = "midi")]
        Midi,
        [EnumMember(Value = "midiSysex")]
        MidiSysex,
        [EnumMember(Value = "nfc")]
        Nfc,
        [EnumMember(Value = "notifications")]
        Notifications,
        [EnumMember(Value = "paymentHandler")]
        PaymentHandler,
        [EnumMember(Value = "periodicBackgroundSync")]
        PeriodicBackgroundSync,
        [EnumMember(Value = "pointerLock")]
        PointerLock,
        [EnumMember(Value = "protectedMediaIdentifier")]
        ProtectedMediaIdentifier,
        [EnumMember(Value = "sensors")]
        Sensors,
        [EnumMember(Value = "smartCard")]
        SmartCard,
        [EnumMember(Value = "speakerSelection")]
        SpeakerSelection,
        [EnumMember(Value = "storageAccess")]
        StorageAccess,
        [EnumMember(Value = "topLevelStorageAccess")]
        TopLevelStorageAccess,
        [EnumMember(Value = "videoCapture")]
        VideoCapture,
        [EnumMember(Value = "vr")]
        Vr,
        [EnumMember(Value = "wakeLockScreen")]
        WakeLockScreen,
        [EnumMember(Value = "wakeLockSystem")]
        WakeLockSystem,
        [EnumMember(Value = "webAppInstallation")]
        WebAppInstallation,
        [EnumMember(Value = "webPrinting")]
        WebPrinting,
        [EnumMember(Value = "windowManagement")]
        WindowManagement,
    }
}