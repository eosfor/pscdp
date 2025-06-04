namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum of shared storage access methods.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SharedStorageAccessMethod
    {
        [EnumMember(Value = "addModule")]
        AddModule,
        [EnumMember(Value = "createWorklet")]
        CreateWorklet,
        [EnumMember(Value = "selectURL")]
        SelectURL,
        [EnumMember(Value = "run")]
        Run,
        [EnumMember(Value = "batchUpdate")]
        BatchUpdate,
        [EnumMember(Value = "set")]
        Set,
        [EnumMember(Value = "append")]
        Append,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "clear")]
        Clear,
        [EnumMember(Value = "get")]
        Get,
        [EnumMember(Value = "keys")]
        Keys,
        [EnumMember(Value = "values")]
        Values,
        [EnumMember(Value = "entries")]
        Entries,
        [EnumMember(Value = "length")]
        Length,
        [EnumMember(Value = "remainingBudget")]
        RemainingBudget,
    }
}