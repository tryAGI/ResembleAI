#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentToolsClient
    {
        /// <summary>
        /// Delete agent tool<br/>
        /// Delete a tool
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="toolUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentToolsDeleteAgentToolResponse200> DeleteAgentToolAsync(
            global::System.Guid agentUuid,
            global::System.Guid toolUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete agent tool<br/>
        /// Delete a tool
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="toolUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentToolsDeleteAgentToolResponse200>> DeleteAgentToolAsResponseAsync(
            global::System.Guid agentUuid,
            global::System.Guid toolUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}