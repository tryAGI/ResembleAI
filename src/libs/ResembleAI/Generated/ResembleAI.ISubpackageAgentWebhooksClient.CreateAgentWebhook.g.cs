#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentWebhooksClient
    {
        /// <summary>
        /// Create agent webhook<br/>
        /// Create a new webhook for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksCreateAgentWebhookResponse200> CreateAgentWebhookAsync(
            global::System.Guid agentUuid,

            global::ResembleAI.CreateAgentWebhookRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent webhook<br/>
        /// Create a new webhook for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentWebhooksCreateAgentWebhookResponse200>> CreateAgentWebhookAsResponseAsync(
            global::System.Guid agentUuid,

            global::ResembleAI.CreateAgentWebhookRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent webhook<br/>
        /// Create a new webhook for an agent
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookType"></param>
        /// <param name="webhookConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksCreateAgentWebhookResponse200> CreateAgentWebhookAsync(
            global::System.Guid agentUuid,
            global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType webhookType,
            global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookConfig webhookConfig,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}