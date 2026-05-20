
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentWebhookRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType WebhookType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookConfig WebhookConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebhookRequest" /> class.
        /// </summary>
        /// <param name="webhookType"></param>
        /// <param name="webhookConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentWebhookRequest(
            global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType webhookType,
            global::ResembleAI.AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookConfig webhookConfig)
        {
            this.WebhookType = webhookType;
            this.WebhookConfig = webhookConfig ?? throw new global::System.ArgumentNullException(nameof(webhookConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentWebhookRequest" /> class.
        /// </summary>
        public CreateAgentWebhookRequest()
        {
        }

    }
}