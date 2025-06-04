namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resolve the specified values in the context of the provided element.
    /// For example, a value of '1em' is evaluated according to the computed
    /// 'font-size' of the element and a value 'calc(1px + 2px)' will be
    /// resolved to '3px'.
    /// If the `propertyName` was specified the `values` are resolved as if
    /// they were property's declaration. If a value cannot be parsed according
    /// to the provided property syntax, the value is parsed using combined
    /// syntax as if null `propertyName` was provided. If the value cannot be
    /// resolved even then, return the provided value without any changes.
    /// </summary>
    public sealed class ResolveValuesCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.resolveValues";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Substitution functions (var()/env()/attr()) and cascade-dependent
        /// keywords (revert/revert-layer) do not work.
        /// </summary>
        [JsonProperty("values")]
        public string[] Values
        {
            get;
            set;
        }
        /// <summary>
        /// Id of the node in whose context the expression is evaluated
        /// </summary>
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
        /// <summary>
        /// Only longhands and custom property names are accepted.
        /// </summary>
        [JsonProperty("propertyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PropertyName
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo element type, only works for pseudo elements that generate
        /// elements in the tree, such as ::before and ::after.
        /// </summary>
        [JsonProperty("pseudoType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DOM.PseudoType PseudoType
        {
            get;
            set;
        }
        /// <summary>
        /// Pseudo element custom ident.
        /// </summary>
        [JsonProperty("pseudoIdentifier", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PseudoIdentifier
        {
            get;
            set;
        }
    }

    public sealed class ResolveValuesCommandResponse : ICommandResponse<ResolveValuesCommand>
    {
        /// <summary>
        /// Gets or sets the results
        /// </summary>
        [JsonProperty("results")]
        public string[] Results
        {
            get;
            set;
        }
    }
}