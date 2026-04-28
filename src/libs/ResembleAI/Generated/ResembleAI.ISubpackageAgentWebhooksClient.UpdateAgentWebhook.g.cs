#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentWebhooksClient
    {
        /// <summary>
        /// Update agent webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksUpdateAgentWebhookResponse200> UpdateAgentWebhookAsync(
            global::System.Guid agentUuid,
            global::System.Guid webhookUuid,

            global::ResembleAI.UpdateAgentWebhookRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent webhook<br/>
        /// Update an existing webhook
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookUuid"></param>
        /// <param name="webhookConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksUpdateAgentWebhookResponse200> UpdateAgentWebhookAsync(
            global::System.Guid agentUuid,
            global::System.Guid webhookUuid,
            global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidPatchRequestBodyContentApplicationJsonSchemaWebhookConfig? webhookConfig = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}