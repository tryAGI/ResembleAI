#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentsClient
    {
        /// <summary>
        /// List agents<br/>
        /// Retrieve all agents for the authenticated team
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="advanced">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsListAgentsResponse200> ListAgentsAsync(
            string? phoneNumber = default,
            bool? advanced = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}