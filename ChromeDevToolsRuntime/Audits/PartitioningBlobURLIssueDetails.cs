namespace BaristaLabs.ChromeDevTools.Runtime.Audits
{
    using Newtonsoft.Json;

    /// <summary>
    /// PartitioningBlobURLIssueDetails
    /// </summary>
    public sealed class PartitioningBlobURLIssueDetails
    {
        /// <summary>
        /// The BlobURL that failed to load.
        ///</summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// Additional information about the Partitioning Blob URL issue.
        ///</summary>
        [JsonProperty("partitioningBlobURLInfo")]
        public PartitioningBlobURLInfo PartitioningBlobURLInfo
        {
            get;
            set;
        }
    }
}