namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// AttributionReportingNamedBudgetDef
    /// </summary>
    public sealed class AttributionReportingNamedBudgetDef
    {
        /// <summary>
        /// name
        ///</summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// budget
        ///</summary>
        [JsonProperty("budget")]
        public long Budget
        {
            get;
            set;
        }
    }
}