#nullable enable

namespace ResembleAI
{
    public partial interface IAgentWebhooksClient
    {
        /// <summary>
        /// Get agent webhook<br/>
        /// Get details of a specific webhook
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksGetAgentWebhookResponse200> GetAgentWebhookAsync(
            global::System.Guid agentUuid,
            global::System.Guid webhookUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent webhook<br/>
        /// Get details of a specific webhook
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentWebhooksGetAgentWebhookResponse200>> GetAgentWebhookAsResponseAsync(
            global::System.Guid agentUuid,
            global::System.Guid webhookUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}