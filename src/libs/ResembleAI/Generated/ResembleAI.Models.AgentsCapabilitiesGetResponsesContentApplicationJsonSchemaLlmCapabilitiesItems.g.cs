
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems
    {
        /// <summary>
        /// LLM provider name (e.g., "openai", "anthropic")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Model identifier (e.g., "gpt-4o", "claude-3-5-sonnet-20241022")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Human-readable description of the capability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems" /> class.
        /// </summary>
        /// <param name="provider">
        /// LLM provider name (e.g., "openai", "anthropic")
        /// </param>
        /// <param name="model">
        /// Model identifier (e.g., "gpt-4o", "claude-3-5-sonnet-20241022")
        /// </param>
        /// <param name="description">
        /// Human-readable description of the capability
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems(
            string? provider,
            string? model,
            string? description)
        {
            this.Provider = provider;
            this.Model = model;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems" /> class.
        /// </summary>
        public AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems()
        {
        }
    }
}