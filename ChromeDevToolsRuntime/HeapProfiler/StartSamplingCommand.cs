namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// StartSampling
    /// </summary>
    public sealed class StartSamplingCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.startSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Average sample interval in bytes. Poisson distribution is used for the intervals. The
        /// default value is 32768 bytes.
        /// </summary>
        [JsonProperty("samplingInterval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? SamplingInterval
        {
            get;
            set;
        }
        /// <summary>
        /// By default, the sampling heap profiler reports only objects which are
        /// still alive when the profile is returned via getSamplingProfile or
        /// stopSampling, which is useful for determining what functions contribute
        /// the most to steady-state memory usage. This flag instructs the sampling
        /// heap profiler to also include information about objects discarded by
        /// major GC, which will show which functions cause large temporary memory
        /// usage or long GC pauses.
        /// </summary>
        [JsonProperty("includeObjectsCollectedByMajorGC", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeObjectsCollectedByMajorGC
        {
            get;
            set;
        }
        /// <summary>
        /// By default, the sampling heap profiler reports only objects which are
        /// still alive when the profile is returned via getSamplingProfile or
        /// stopSampling, which is useful for determining what functions contribute
        /// the most to steady-state memory usage. This flag instructs the sampling
        /// heap profiler to also include information about objects discarded by
        /// minor GC, which is useful when tuning a latency-sensitive application
        /// for minimal GC activity.
        /// </summary>
        [JsonProperty("includeObjectsCollectedByMinorGC", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IncludeObjectsCollectedByMinorGC
        {
            get;
            set;
        }
    }

    public sealed class StartSamplingCommandResponse : ICommandResponse<StartSamplingCommand>
    {
    }
}