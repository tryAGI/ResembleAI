
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentWebhookRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_config")]
        public global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidPatchRequestBodyContentApplicationJsonSchemaWebhookConfig? WebhookConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentWebhookRequest" /> class.
        /// </summary>
        /// <param name="webhookConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentWebhookRequest(
            global::ResembleAI.AgentsAgentUuidWebhooksWebhookUuidPatchRequestBodyContentApplicationJsonSchemaWebhookConfig? webhookConfig)
        {
            this.WebhookConfig = webhookConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentWebhookRequest" /> class.
        /// </summary>
        public UpdateAgentWebhookRequest()
        {
        }

    }
}