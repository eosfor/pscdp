namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// WasmDisassemblyChunk
    /// </summary>
    public sealed class WasmDisassemblyChunk
    {
        /// <summary>
        /// The next chunk of disassembled lines.
        ///</summary>
        [JsonProperty("lines")]
        public string[] Lines
        {
            get;
            set;
        }
        /// <summary>
        /// The bytecode offsets describing the start of each line.
        ///</summary>
        [JsonProperty("bytecodeOffsets")]
        public long[] BytecodeOffsets
        {
            get;
            set;
        }
    }
}