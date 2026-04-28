
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentToolRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolConfig ToolConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="toolType"></param>
        /// <param name="toolConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentToolRequest(
            string name,
            string description,
            global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType toolType,
            global::ResembleAI.AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolConfig toolConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ToolType = toolType;
            this.ToolConfig = toolConfig ?? throw new global::System.ArgumentNullException(nameof(toolConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentToolRequest" /> class.
        /// </summary>
        public CreateAgentToolRequest()
        {
        }
    }
}