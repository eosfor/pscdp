namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Specificity:
    /// https://drafts.csswg.org/selectors/#specificity-rules
    /// </summary>
    public sealed class Specificity
    {
        /// <summary>
        /// The a component, which represents the number of ID selectors.
        ///</summary>
        [JsonProperty("a")]
        public long A
        {
            get;
            set;
        }
        /// <summary>
        /// The b component, which represents the number of class selectors, attributes selectors, and
        /// pseudo-classes.
        ///</summary>
        [JsonProperty("b")]
        public long B
        {
            get;
            set;
        }
        /// <summary>
        /// The c component, which represents the number of type selectors and pseudo-elements.
        ///</summary>
        [JsonProperty("c")]
        public long C
        {
            get;
            set;
        }
    }
}