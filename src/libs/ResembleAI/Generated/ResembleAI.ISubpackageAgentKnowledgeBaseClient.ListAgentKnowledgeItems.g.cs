#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentKnowledgeBaseClient
    {
        /// <summary>
        /// List agent's knowledge items<br/>
        /// Lists all knowledge items attached to a specific agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseListAgentKnowledgeItemsResponse200> ListAgentKnowledgeItemsAsync(
            global::System.Guid agentUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}