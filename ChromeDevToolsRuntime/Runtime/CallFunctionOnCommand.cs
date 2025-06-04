namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Calls function with given declaration on the given object. Object group of the result is
    /// inherited from the target object.
    /// </summary>
    public sealed class CallFunctionOnCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.callFunctionOn";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Declaration of the function to call.
        /// </summary>
        [JsonProperty("functionDeclaration")]
        public string FunctionDeclaration
        {
            get;
            set;
        }
        /// <summary>
        /// Identifier of the object to call function on. Either objectId or executionContextId should
        /// be specified.
        /// </summary>
        [JsonProperty("objectId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectId
        {
            get;
            set;
        }
        /// <summary>
        /// Call arguments. All call arguments must belong to the same JavaScript world as the target
        /// object.
        /// </summary>
        [JsonProperty("arguments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallArgument[] Arguments
        {
            get;
            set;
        }
        /// <summary>
        /// In silent mode exceptions thrown during evaluation are not reported and do not pause
        /// execution. Overrides `setPauseOnException` state.
        /// </summary>
        [JsonProperty("silent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Silent
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the result is expected to be a JSON object which should be sent by value.
        /// Can be overriden by `serializationOptions`.
        /// </summary>
        [JsonProperty("returnByValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ReturnByValue
        {
            get;
            set;
        }
        /// <summary>
        /// Whether preview should be generated for the result.
        /// </summary>
        [JsonProperty("generatePreview", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? GeneratePreview
        {
            get;
            set;
        }
        /// <summary>
        /// Whether execution should be treated as initiated by user in the UI.
        /// </summary>
        [JsonProperty("userGesture", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? UserGesture
        {
            get;
            set;
        }
        /// <summary>
        /// Whether execution should `await` for resulting value and return once awaited promise is
        /// resolved.
        /// </summary>
        [JsonProperty("awaitPromise", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AwaitPromise
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies execution context which global object will be used to call function on. Either
        /// executionContextId or objectId should be specified.
        /// </summary>
        [JsonProperty("executionContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? ExecutionContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Symbolic group name that can be used to release multiple objects. If objectGroup is not
        /// specified and objectId is, objectGroup will be inherited from object.
        /// </summary>
        [JsonProperty("objectGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ObjectGroup
        {
            get;
            set;
        }
        /// <summary>
        /// Whether to throw an exception if side effect cannot be ruled out during evaluation.
        /// </summary>
        [JsonProperty("throwOnSideEffect", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ThrowOnSideEffect
        {
            get;
            set;
        }
        /// <summary>
        /// An alternative way to specify the execution context to call function on.
        /// Compared to contextId that may be reused across processes, this is guaranteed to be
        /// system-unique, so it can be used to prevent accidental function call
        /// in context different than intended (e.g. as a result of navigation across process
        /// boundaries).
        /// This is mutually exclusive with `executionContextId`.
        /// </summary>
        [JsonProperty("uniqueContextId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UniqueContextId
        {
            get;
            set;
        }
        /// <summary>
        /// Specifies the result serialization. If provided, overrides
        /// `generatePreview` and `returnByValue`.
        /// </summary>
        [JsonProperty("serializationOptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SerializationOptions SerializationOptions
        {
            get;
            set;
        }
    }

    public sealed class CallFunctionOnCommandResponse : ICommandResponse<CallFunctionOnCommand>
    {
        /// <summary>
        /// Call result.
        ///</summary>
        [JsonProperty("result")]
        public RemoteObject Result
        {
            get;
            set;
        }
        /// <summary>
        /// Exception details.
        ///</summary>
        [JsonProperty("exceptionDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    }
}