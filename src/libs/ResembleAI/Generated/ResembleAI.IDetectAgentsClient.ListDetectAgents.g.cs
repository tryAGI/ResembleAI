#nullable enable

namespace ResembleAI
{
    public partial interface IDetectAgentsClient
    {
        /// <summary>
        /// List Detect Agents<br/>
        /// Return all six managed Detect Agents available to the authenticated team.<br/>
        /// Use an agent's `uuid` to run an investigation or retrieve its run history.<br/>
        /// This endpoint does not accept pagination or filtering parameters.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectAgentsListDetectAgentsResponse200> ListDetectAgentsAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Detect Agents<br/>
        /// Return all six managed Detect Agents available to the authenticated team.<br/>
        /// Use an agent's `uuid` to run an investigation or retrieve its run history.<br/>
        /// This endpoint does not accept pagination or filtering parameters.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DetectAgentsListDetectAgentsResponse200>> ListDetectAgentsAsResponseAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}