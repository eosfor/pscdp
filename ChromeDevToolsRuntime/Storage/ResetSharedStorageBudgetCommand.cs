namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resets the budget for `ownerOrigin` by clearing all budget withdrawals.
    /// </summary>
    public sealed class ResetSharedStorageBudgetCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.resetSharedStorageBudget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Gets or sets the ownerOrigin
        /// </summary>
        [JsonProperty("ownerOrigin")]
        public string OwnerOrigin
        {
            get;
            set;
        }
    }

    public sealed class ResetSharedStorageBudgetCommandResponse : ICommandResponse<ResetSharedStorageBudgetCommand>
    {
    }
}