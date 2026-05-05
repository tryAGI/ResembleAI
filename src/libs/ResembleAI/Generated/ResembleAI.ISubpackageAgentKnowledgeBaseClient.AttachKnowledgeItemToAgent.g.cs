#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Attach knowledge item to agent<br/>
        /// Attaches an existing knowledge item to an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseAttachKnowledgeItemToAgentResponse201> AttachKnowledgeItemToAgentAsync(
            global::System.Guid agentUuid,

            global::ResembleAI.AttachKnowledgeItemToAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach knowledge item to agent<br/>
        /// Attaches an existing knowledge item to an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentKnowledgeBaseAttachKnowledgeItemToAgentResponse201>> AttachKnowledgeItemToAgentAsResponseAsync(
            global::System.Guid agentUuid,

            global::ResembleAI.AttachKnowledgeItemToAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach knowledge item to agent<br/>
        /// Attaches an existing knowledge item to an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="knowledgeItemUuid">
        /// The UUID of the knowledge item to attach
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseAttachKnowledgeItemToAgentResponse201> AttachKnowledgeItemToAgentAsync(
            global::System.Guid agentUuid,
            global::System.Guid knowledgeItemUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}