
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsGetAgentCapabilitiesResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr_capabilities")]
        public global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems>? AsrCapabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_capabilities")]
        public global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems>? LlmCapabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentCapabilitiesResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="asrCapabilities"></param>
        /// <param name="llmCapabilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsGetAgentCapabilitiesResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaAsrCapabilitiesItems>? asrCapabilities,
            global::System.Collections.Generic.IList<global::ResembleAI.AgentsCapabilitiesGetResponsesContentApplicationJsonSchemaLlmCapabilitiesItems>? llmCapabilities)
        {
            this.Success = success;
            this.AsrCapabilities = asrCapabilities;
            this.LlmCapabilities = llmCapabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentCapabilitiesResponse200" /> class.
        /// </summary>
        public AgentsGetAgentCapabilitiesResponse200()
        {
        }
    }
}