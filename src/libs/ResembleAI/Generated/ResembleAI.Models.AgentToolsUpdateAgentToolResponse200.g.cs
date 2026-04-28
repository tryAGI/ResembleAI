
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentToolsUpdateAgentToolResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchResponsesContentApplicationJsonSchemaItem? Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolsUpdateAgentToolResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="item"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentToolsUpdateAgentToolResponse200(
            bool? success,
            global::ResembleAI.AgentsAgentUuidToolsToolUuidPatchResponsesContentApplicationJsonSchemaItem? item,
            string? message)
        {
            this.Success = success;
            this.Item = item;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolsUpdateAgentToolResponse200" /> class.
        /// </summary>
        public AgentToolsUpdateAgentToolResponse200()
        {
        }
    }
}