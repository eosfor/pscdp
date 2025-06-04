namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Allows overriding the difference between the small and large viewport sizes, which determine the
    /// value of the `svh` and `lvh` unit, respectively. Only supported for top-level frames.
    /// </summary>
    public sealed class SetSmallViewportHeightDifferenceOverrideCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setSmallViewportHeightDifferenceOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// This will cause an element of size 100svh to be `difference` pixels smaller than an element
        /// of size 100lvh.
        /// </summary>
        [JsonProperty("difference")]
        public long Difference
        {
            get;
            set;
        }
    }

    public sealed class SetSmallViewportHeightDifferenceOverrideCommandResponse : ICommandResponse<SetSmallViewportHeightDifferenceOverrideCommand>
    {
    }
}