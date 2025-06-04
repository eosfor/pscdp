namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// DisassembleWasmModule
    /// </summary>
    public sealed class DisassembleWasmModuleCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.disassembleWasmModule";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Id of the script to disassemble
        /// </summary>
        [JsonProperty("scriptId")]
        public string ScriptId
        {
            get;
            set;
        }
    }

    public sealed class DisassembleWasmModuleCommandResponse : ICommandResponse<DisassembleWasmModuleCommand>
    {
        /// <summary>
        /// For large modules, return a stream from which additional chunks of
        /// disassembly can be read successively.
        ///</summary>
        [JsonProperty("streamId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreamId
        {
            get;
            set;
        }
        /// <summary>
        /// The total number of lines in the disassembly text.
        ///</summary>
        [JsonProperty("totalNumberOfLines")]
        public long TotalNumberOfLines
        {
            get;
            set;
        }
        /// <summary>
        /// The offsets of all function bodies, in the format [start1, end1,
        /// start2, end2, ...] where all ends are exclusive.
        ///</summary>
        [JsonProperty("functionBodyOffsets")]
        public long[] FunctionBodyOffsets
        {
            get;
            set;
        }
        /// <summary>
        /// The first chunk of disassembly.
        ///</summary>
        [JsonProperty("chunk")]
        public WasmDisassemblyChunk Chunk
        {
            get;
            set;
        }
    }
}