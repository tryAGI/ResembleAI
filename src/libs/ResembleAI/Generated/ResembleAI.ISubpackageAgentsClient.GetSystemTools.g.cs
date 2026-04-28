#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentsClient
    {
        /// <summary>
        /// Get system tools<br/>
        /// List available system tools
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsGetSystemToolsResponse200> GetSystemToolsAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}