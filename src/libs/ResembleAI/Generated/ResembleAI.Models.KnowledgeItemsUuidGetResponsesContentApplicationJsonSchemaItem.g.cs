
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeJsonConverter))]
        public global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter))]
        public global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus? Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemAgentsItems>? Agents { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
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
        /// <param name="agents"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem(
            global::System.Guid? uuid,
            string? title,
            string? description,
            global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType? sourceType,
            global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus? status,
            string? errorMessage,
            int? chunkCount,
            string? url,
            string? documentUrl,
            string? documentFilename,
            global::System.Collections.Generic.IList<global::ResembleAI.KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemAgentsItems>? agents,
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
            this.Agents = agents;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}