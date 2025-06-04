namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// A shared storage run or selectURL operation finished its execution.
    /// The following parameters are included in all events.
    /// </summary>
    public sealed class SharedStorageWorkletOperationExecutionFinishedEvent : IEvent
    {
        /// <summary>
        /// Time that the operation finished.
        /// </summary>
        [JsonProperty("finishedTime")]
        public double FinishedTime
        {
            get;
            set;
        }
        /// <summary>
        /// Time, in microseconds, from start of shared storage JS API call until
        /// end of operation execution in the worklet.
        /// </summary>
        [JsonProperty("executionTime")]
        public long ExecutionTime
        {
            get;
            set;
        }
        /// <summary>
        /// Enum value indicating the Shared Storage API method invoked.
        /// </summary>
        [JsonProperty("method")]
        public SharedStorageAccessMethod Method
        {
            get;
            set;
        }
        /// <summary>
        /// ID of the operation call.
        /// </summary>
        [JsonProperty("operationId")]
        public string OperationId
        {
            get;
            set;
        }
        /// <summary>
        /// Hex representation of the DevTools token used as the TargetID for the
        /// associated shared storage worklet.
        /// </summary>
        [JsonProperty("workletTargetId")]
        public string WorkletTargetId
        {
            get;
            set;
        }
        /// <summary>
        /// DevTools Frame Token for the primary frame tree's root.
        /// </summary>
        [JsonProperty("mainFrameId")]
        public string MainFrameId
        {
            get;
            set;
        }
        /// <summary>
        /// Serialization of the origin owning the Shared Storage data.
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
    }
}