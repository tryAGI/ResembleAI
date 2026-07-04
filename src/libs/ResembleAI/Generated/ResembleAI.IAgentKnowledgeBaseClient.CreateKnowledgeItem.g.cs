#nullable enable

namespace ResembleAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Create knowledge item<br/>
        /// Creates a new knowledge item and queues it for ingestion processing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseCreateKnowledgeItemResponse201> CreateKnowledgeItemAsync(

            global::ResembleAI.CreateKnowledgeItemRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create knowledge item<br/>
        /// Creates a new knowledge item and queues it for ingestion processing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentKnowledgeBaseCreateKnowledgeItemResponse201>> CreateKnowledgeItemAsResponseAsync(

            global::ResembleAI.CreateKnowledgeItemRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create knowledge item<br/>
        /// Creates a new knowledge item and queues it for ingestion processing
        /// </summary>
        /// <param name="title">
        /// Title of the knowledge item
        /// </param>
        /// <param name="description">
        /// Description of the knowledge item
        /// </param>
        /// <param name="sourceType">
        /// Type of knowledge source
        /// </param>
        /// <param name="url">
        /// Required when source_type is url
        /// </param>
        /// <param name="rawText">
        /// Required when source_type is text
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseCreateKnowledgeItemResponse201> CreateKnowledgeItemAsync(
            string title,
            string description,
            global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType sourceType,
            string? url = default,
            string? rawText = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}