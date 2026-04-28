
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentKnowledgeBaseCreateKnowledgeItemResponse201
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
        public global::ResembleAI.KnowledgeItemsPostResponsesContentApplicationJsonSchemaItem? Item { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseCreateKnowledgeItemResponse201" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="item"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseCreateKnowledgeItemResponse201(
            bool? success,
            global::ResembleAI.KnowledgeItemsPostResponsesContentApplicationJsonSchemaItem? item,
            string? message)
        {
            this.Success = success;
            this.Item = item;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseCreateKnowledgeItemResponse201" /> class.
        /// </summary>
        public AgentKnowledgeBaseCreateKnowledgeItemResponse201()
        {
        }
    }
}