
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentToolRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        public global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchRequestBodyContentApplicationJsonSchemaToolConfig? ToolConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentToolRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="toolConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentToolRequest(
            string? name,
            string? description,
            global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchRequestBodyContentApplicationJsonSchemaToolConfig? toolConfig)
        {
            this.Name = name;
            this.Description = description;
            this.ToolConfig = toolConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentToolRequest" /> class.
        /// </summary>
        public UpdateAgentToolRequest()
        {
        }

    }
}