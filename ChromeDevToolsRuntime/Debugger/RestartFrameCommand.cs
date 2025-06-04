namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Restarts particular call frame from the beginning. The old, deprecated
    /// behavior of `restartFrame` is to stay paused and allow further CDP commands
    /// after a restart was scheduled. This can cause problems with restarting, so
    /// we now continue execution immediatly after it has been scheduled until we
    /// reach the beginning of the restarted frame.
    /// 
    /// To stay back-wards compatible, `restartFrame` now expects a `mode`
    /// parameter to be present. If the `mode` parameter is missing, `restartFrame`
    /// errors out.
    /// 
    /// The various return values are deprecated and `callFrames` is always empty.
    /// Use the call frames from the `Debugger#paused` events instead, that fires
    /// once V8 pauses at the beginning of the restarted function.
    /// </summary>
    public sealed class RestartFrameCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.restartFrame";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Call frame identifier to evaluate on.
        /// </summary>
        [JsonProperty("callFrameId")]
        public string CallFrameId
        {
            get;
            set;
        }
        /// <summary>
        /// The `mode` parameter must be present and set to 'StepInto', otherwise
        /// `restartFrame` will error out.
        /// </summary>
        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mode
        {
            get;
            set;
        }
    }

    public sealed class RestartFrameCommandResponse : ICommandResponse<RestartFrameCommand>
    {
        /// <summary>
        /// New stack trace.
        ///</summary>
        [JsonProperty("callFrames")]
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
        /// <summary>
        /// Async stack trace, if any.
        ///</summary>
        [JsonProperty("asyncStackTrace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runtime.StackTrace AsyncStackTrace
        {
            get;
            set;
        }
        /// <summary>
        /// Async stack trace, if any.
        ///</summary>
        [JsonProperty("asyncStackTraceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runtime.StackTraceId AsyncStackTraceId
        {
            get;
            set;
        }
    }
}