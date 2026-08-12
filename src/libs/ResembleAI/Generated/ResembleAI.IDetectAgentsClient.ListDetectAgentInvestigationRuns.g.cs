#nullable enable

namespace ResembleAI
{
    public partial interface IDetectAgentsClient
    {
        /// <summary>
        /// List investigation runs<br/>
        /// Return up to 100 of a Detect Agent's most recent investigation runs in<br/>
        /// newest-first order. An agent that the team has never run returns an empty list.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectAgentsListDetectAgentInvestigationRunsResponse200> ListDetectAgentInvestigationRunsAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List investigation runs<br/>
        /// Return up to 100 of a Detect Agent's most recent investigation runs in<br/>
        /// newest-first order. An agent that the team has never run returns an empty list.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DetectAgentsListDetectAgentInvestigationRunsResponse200>> ListDetectAgentInvestigationRunsAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}