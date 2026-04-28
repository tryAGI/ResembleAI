#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentWebhooksClient
    {
        /// <summary>
        /// Delete agent webhook<br/>
        /// Delete a webhook
        /// </summary>
        /// <param name="agentUuid"></param>
        /// <param name="webhookUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentWebhooksDeleteAgentWebhookResponse200> DeleteAgentWebhookAsync(
            global::System.Guid agentUuid,
            global::System.Guid webhookUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}