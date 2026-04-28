#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Detach knowledge item from agent<br/>
        /// Removes a knowledge item from an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="knowledgeItemUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseDetachKnowledgeItemFromAgentResponse200> DetachKnowledgeItemFromAgentAsync(
            global::System.Guid agentUuid,
            global::System.Guid knowledgeItemUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}