#nullable enable

namespace ResembleAI
{
    public partial interface IDetectAgentsClient
    {
        /// <summary>
        /// Get investigation run<br/>
        /// Retrieve a persisted investigation run, including its replay transcript<br/>
        /// and the exact configuration and memory snapshots used by the investigation.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectAgentsGetDetectAgentInvestigationRunResponse200> GetDetectAgentInvestigationRunAsync(
            string uuid,
            global::System.Guid runId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get investigation run<br/>
        /// Retrieve a persisted investigation run, including its replay transcript<br/>
        /// and the exact configuration and memory snapshots used by the investigation.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DetectAgentsGetDetectAgentInvestigationRunResponse200>> GetDetectAgentInvestigationRunAsResponseAsync(
            string uuid,
            global::System.Guid runId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}