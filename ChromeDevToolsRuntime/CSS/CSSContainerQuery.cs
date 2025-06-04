namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSS container query rule descriptor.
    /// </summary>
    public sealed class CSSContainerQuery
    {
        /// <summary>
        /// Container query text.
        ///</summary>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// The associated rule header range in the enclosing stylesheet (if
        /// available).
        ///</summary>
        [JsonProperty("range", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SourceRange Range
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the stylesheet containing this object (if exists).
        ///</summary>
        [JsonProperty("styleSheetId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StyleSheetId
        {
            get;
            set;
        }
        /// <summary>
        /// Optional name for the container.
        ///</summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Optional physical axes queried for the container.
        ///</summary>
        [JsonProperty("physicalAxes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.PhysicalAxes PhysicalAxes
        {
            get;
            set;
        }
        /// <summary>
        /// Optional logical axes queried for the container.
        ///</summary>
        [JsonProperty("logicalAxes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.LogicalAxes LogicalAxes
        {
            get;
            set;
        }
        /// <summary>
        /// true if the query contains scroll-state() queries.
        ///</summary>
        [JsonProperty("queriesScrollState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? QueriesScrollState
        {
            get;
            set;
        }
    }
}