#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentToolsClient
    {
        /// <summary>
        /// Create agent tool<br/>
        /// Create a new tool for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentToolsCreateAgentToolResponse200> CreateAgentToolAsync(
            global::System.Guid agentUuid,

            global::ResembleAI.CreateAgentToolRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent tool<br/>
        /// Create a new tool for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="toolType"></param>
        /// <param name="toolConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentToolsCreateAgentToolResponse200> CreateAgentToolAsync(
            global::System.Guid agentUuid,
            string name,
            string description,
            global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType toolType,
            global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolConfig toolConfig,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}