namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// A structure to hold the top-level node of a detached tree and an array of its retained descendants.
    /// </summary>
    public sealed class DetachedElementInfo
    {
        /// <summary>
        /// treeNode
        ///</summary>
        [JsonProperty("treeNode")]
        public Node TreeNode
        {
            get;
            set;
        }
        /// <summary>
        /// retainedNodeIds
        ///</summary>
        [JsonProperty("retainedNodeIds")]
        public long[] RetainedNodeIds
        {
            get;
            set;
        }
    }
}