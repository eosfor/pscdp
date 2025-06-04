namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents deep serialized value.
    /// </summary>
    public sealed class DeepSerializedValue
    {
        /// <summary>
        /// type
        ///</summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// value
        ///</summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Value
        {
            get;
            set;
        }
        /// <summary>
        /// objectId
        ///</summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Set if value reference met more then once during serialization. In such
        /// case, value is provided only to one of the serialized values. Unique
        /// per value in the scope of one CDP call.
        ///</summary>
        [JsonProperty("weakLocalObjectReference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? WeakLocalObjectReference
        {
            get;
            set;
        }
    }
}