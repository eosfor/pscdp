namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// ResolvedBreakpoint
    /// </summary>
    public sealed class ResolvedBreakpoint
    {
        /// <summary>
        /// Breakpoint unique identifier.
        ///</summary>
        [JsonProperty("breakpointId")]
        public string BreakpointId
        {
            get;
            set;
        }
        /// <summary>
        /// Actual breakpoint location.
        ///</summary>
        [JsonProperty("location")]
        public Location Location
        {
            get;
            set;
        }
    }
}