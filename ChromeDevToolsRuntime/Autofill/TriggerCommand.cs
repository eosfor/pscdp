namespace BaristaLabs.ChromeDevTools.Runtime.Autofill
{
    using Newtonsoft.Json;

    /// <summary>
    /// Trigger autofill on a form identified by the fieldId.
    /// If the field and related form cannot be autofilled, returns an error.
    /// </summary>
    public sealed class TriggerCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Autofill.trigger";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Identifies a field that serves as an anchor for autofill.
        /// </summary>
        [JsonProperty("fieldId")]
        public long FieldId
        {
            get;
            set;
        }
        /// <summary>
        /// Identifies the frame that field belongs to.
        /// </summary>
        [JsonProperty("frameId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Credit card information to fill out the form. Credit card data is not saved.
        /// </summary>
        [JsonProperty("card")]
        public CreditCard Card
        {
            get;
            set;
        }
    }

    public sealed class TriggerCommandResponse : ICommandResponse<TriggerCommand>
    {
    }
}