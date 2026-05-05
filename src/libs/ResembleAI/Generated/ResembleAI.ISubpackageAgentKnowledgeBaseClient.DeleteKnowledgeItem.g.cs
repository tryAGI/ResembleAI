#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Delete knowledge item<br/>
        /// Deletes a knowledge item and cleans up associated data
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentKnowledgeBaseDeleteKnowledgeItemResponse200> DeleteKnowledgeItemAsync(
            global::System.Guid uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete knowledge item<br/>
        /// Deletes a knowledge item and cleans up associated data
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentKnowledgeBaseDeleteKnowledgeItemResponse200>> DeleteKnowledgeItemAsResponseAsync(
            global::System.Guid uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}