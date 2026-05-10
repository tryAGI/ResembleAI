
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachKnowledgeItemToAgentRequest
    {
        /// <summary>
        /// The UUID of the knowledge item to attach
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_item_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid KnowledgeItemUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachKnowledgeItemToAgentRequest" /> class.
        /// </summary>
        /// <param name="knowledgeItemUuid">
        /// The UUID of the knowledge item to attach
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachKnowledgeItemToAgentRequest(
            global::System.Guid knowledgeItemUuid)
        {
            this.KnowledgeItemUuid = knowledgeItemUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachKnowledgeItemToAgentRequest" /> class.
        /// </summary>
        public AttachKnowledgeItemToAgentRequest()
        {
        }

    }
}