namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Replace previous blackbox execution contexts with passed ones. Forces backend to skip
    /// stepping/pausing in scripts in these execution contexts. VM will try to leave blackboxed script by
    /// performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
    /// </summary>
    public sealed class SetBlackboxExecutionContextsCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setBlackboxExecutionContexts";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Array of execution context unique ids for the debugger to ignore.
        /// </summary>
        [JsonProperty("uniqueIds")]
        public string[] UniqueIds
        {
            get;
            set;
        }
    }

    public sealed class SetBlackboxExecutionContextsCommandResponse : ICommandResponse<SetBlackboxExecutionContextsCommand>
    {
    }
}