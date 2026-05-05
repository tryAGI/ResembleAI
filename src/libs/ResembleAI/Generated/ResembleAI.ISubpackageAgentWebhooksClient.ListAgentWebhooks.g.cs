#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentWebhooksClient
    {
        /// <summary>
        /// List agent webhooks<br/>
        /// List all webhooks for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksListAgentWebhooksResponse200> ListAgentWebhooksAsync(
            global::System.Guid agentUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent webhooks<br/>
        /// List all webhooks for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentWebhooksListAgentWebhooksResponse200>> ListAgentWebhooksAsResponseAsync(
            global::System.Guid agentUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}