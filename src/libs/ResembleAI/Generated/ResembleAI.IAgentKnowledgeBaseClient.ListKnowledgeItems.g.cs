#nullable enable

namespace ResembleAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// List knowledge items<br/>
        /// List all knowledge items belonging to the authenticated user's team
        /// </summary>
        /// <param name="status"></param>
        /// <param name="sourceType"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseListKnowledgeItemsResponse200> ListKnowledgeItemsAsync(
            global::ResembleAI.KnowledgeItemsGetParametersStatus? status = default,
            global::ResembleAI.KnowledgeItemsGetParametersSourceType? sourceType = default,
            int? page = default,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List knowledge items<br/>
        /// List all knowledge items belonging to the authenticated user's team
        /// </summary>
        /// <param name="status"></param>
        /// <param name="sourceType"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentKnowledgeBaseListKnowledgeItemsResponse200>> ListKnowledgeItemsAsResponseAsync(
            global::ResembleAI.KnowledgeItemsGetParametersStatus? status = default,
            global::ResembleAI.KnowledgeItemsGetParametersSourceType? sourceType = default,
            int? page = default,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}