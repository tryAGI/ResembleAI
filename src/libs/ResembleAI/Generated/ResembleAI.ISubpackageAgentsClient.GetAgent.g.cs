#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentsClient
    {
        /// <summary>
        /// Get agent<br/>
        /// Retrieve a specific agent's details
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="advanced">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsGetAgentResponse200> GetAgentAsync(
            global::System.Guid uuid,
            bool? advanced = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}