#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentToolsClient
    {
        /// <summary>
        /// Update agent tool<br/>
        /// Update an existing tool
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="toolUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentToolsUpdateAgentToolResponse200> UpdateAgentToolAsync(
            global::System.Guid agentUuid,
            global::System.Guid toolUuid,

            global::ResembleAI.UpdateAgentToolRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent tool<br/>
        /// Update an existing tool
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="toolUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentToolsUpdateAgentToolResponse200>> UpdateAgentToolAsResponseAsync(
            global::System.Guid agentUuid,
            global::System.Guid toolUuid,

            global::ResembleAI.UpdateAgentToolRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent tool<br/>
        /// Update an existing tool
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="toolUuid"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="toolConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentToolsUpdateAgentToolResponse200> UpdateAgentToolAsync(
            global::System.Guid agentUuid,
            global::System.Guid toolUuid,
            string? name = default,
            string? description = default,
            global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchRequestBodyContentApplicationJsonSchemaToolConfig? toolConfig = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}