namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Pseudo element type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PseudoType
    {
        [EnumMember(Value = "first-line")]
        FirstLine,
        [EnumMember(Value = "first-letter")]
        FirstLetter,
        [EnumMember(Value = "checkmark")]
        Checkmark,
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "picker-icon")]
        PickerIcon,
        [EnumMember(Value = "marker")]
        Marker,
        [EnumMember(Value = "backdrop")]
        Backdrop,
        [EnumMember(Value = "column")]
        Column,
        [EnumMember(Value = "selection")]
        Selection,
        [EnumMember(Value = "search-text")]
        SearchText,
        [EnumMember(Value = "target-text")]
        TargetText,
        [EnumMember(Value = "spelling-error")]
        SpellingError,
        [EnumMember(Value = "grammar-error")]
        GrammarError,
        [EnumMember(Value = "highlight")]
        Highlight,
        [EnumMember(Value = "first-line-inherited")]
        FirstLineInherited,
        [EnumMember(Value = "scroll-marker")]
        ScrollMarker,
        [EnumMember(Value = "scroll-marker-group")]
        ScrollMarkerGroup,
        [EnumMember(Value = "scroll-button")]
        ScrollButton,
        [EnumMember(Value = "scrollbar")]
        Scrollbar,
        [EnumMember(Value = "scrollbar-thumb")]
        ScrollbarThumb,
        [EnumMember(Value = "scrollbar-button")]
        ScrollbarButton,
        [EnumMember(Value = "scrollbar-track")]
        ScrollbarTrack,
        [EnumMember(Value = "scrollbar-track-piece")]
        ScrollbarTrackPiece,
        [EnumMember(Value = "scrollbar-corner")]
        ScrollbarCorner,
        [EnumMember(Value = "resizer")]
        Resizer,
        [EnumMember(Value = "input-list-button")]
        InputListButton,
        [EnumMember(Value = "view-transition")]
        ViewTransition,
        [EnumMember(Value = "view-transition-group")]
        ViewTransitionGroup,
        [EnumMember(Value = "view-transition-image-pair")]
        ViewTransitionImagePair,
        [EnumMember(Value = "view-transition-group-children")]
        ViewTransitionGroupChildren,
        [EnumMember(Value = "view-transition-old")]
        ViewTransitionOld,
        [EnumMember(Value = "view-transition-new")]
        ViewTransitionNew,
        [EnumMember(Value = "placeholder")]
        Placeholder,
        [EnumMember(Value = "file-selector-button")]
        FileSelectorButton,
        [EnumMember(Value = "details-content")]
        DetailsContent,
        [EnumMember(Value = "picker")]
        Picker,
        [EnumMember(Value = "permission-icon")]
        PermissionIcon,
    }
}