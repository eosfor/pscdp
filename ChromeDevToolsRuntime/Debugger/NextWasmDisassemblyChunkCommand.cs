namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disassemble the next chunk of lines for the module corresponding to the
    /// stream. If disassembly is complete, this API will invalidate the streamId
    /// and return an empty chunk. Any subsequent calls for the now invalid stream
    /// will return errors.
    /// </summary>
    public sealed class NextWasmDisassemblyChunkCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.nextWasmDisassemblyChunk";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the streamId
        /// </summary>
        [JsonProperty("streamId")]
        public string StreamId
        {
            get;
            set;
        }
    }

    public sealed class NextWasmDisassemblyChunkCommandResponse : ICommandResponse<NextWasmDisassemblyChunkCommand>
    {
        /// <summary>
        /// The next chunk of disassembly.
        ///</summary>
        [JsonProperty("chunk")]
        public WasmDisassemblyChunk Chunk
        {
            get;
            set;
        }
    }
}