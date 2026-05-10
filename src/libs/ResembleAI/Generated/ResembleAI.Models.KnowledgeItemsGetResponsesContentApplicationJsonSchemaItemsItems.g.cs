
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeJsonConverter))]
        public global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter))]
        public global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_count")]
        public int? ChunkCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        public string? DocumentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_filename")]
        public string? DocumentFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_count")]
        public int? AgentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="sourceType"></param>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="chunkCount"></param>
        /// <param name="url"></param>
        /// <param name="documentUrl"></param>
        /// <param name="documentFilename"></param>
        /// <param name="agentCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems(
            global::System.Guid? uuid,
            string? title,
            string? description,
            global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType? sourceType,
            global::ResembleAI.KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? status,
            string? errorMessage,
            int? chunkCount,
            string? url,
            string? documentUrl,
            string? documentFilename,
            int? agentCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Title = title;
            this.Description = description;
            this.SourceType = sourceType;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.ChunkCount = chunkCount;
            this.Url = url;
            this.DocumentUrl = documentUrl;
            this.DocumentFilename = documentFilename;
            this.AgentCount = agentCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItems()
        {
        }

    }
}