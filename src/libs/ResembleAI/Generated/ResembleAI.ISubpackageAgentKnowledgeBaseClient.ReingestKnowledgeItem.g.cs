#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Re-ingest knowledge item<br/>
        /// Re-runs the ingestion pipeline for an existing knowledge item
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseReingestKnowledgeItemResponse200> ReingestKnowledgeItemAsync(
            global::System.Guid uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}