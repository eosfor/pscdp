namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// PressureMetadata
    /// </summary>
    public sealed class PressureMetadata
    {
        /// <summary>
        /// available
        ///</summary>
        [JsonProperty("available", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Available
        {
            get;
            set;
        }
    }
}