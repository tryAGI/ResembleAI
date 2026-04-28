
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems
    {
        /// <summary>
        /// ASR provider name (e.g., "deepgram")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Model identifier (e.g., "nova-2")
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
        /// Initializes a new instance of the <see cref="AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems" /> class.
        /// </summary>
        /// <param name="provider">
        /// ASR provider name (e.g., "deepgram")
        /// </param>
        /// <param name="model">
        /// Model identifier (e.g., "nova-2")
        /// </param>
        /// <param name="description">
        /// Human-readable description of the capability
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems(
            string? provider,
            string? model,
            string? description)
        {
            this.Provider = provider;
            this.Model = model;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems" /> class.
        /// </summary>
        public AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems()
        {
        }
    }
}