
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKnowledgeItemRequest
    {
        /// <summary>
        /// Title of the knowledge item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Description of the knowledge item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Type of knowledge source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType SourceType { get; set; }

        /// <summary>
        /// Required when source_type is url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Required when source_type is text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_text")]
        public string? RawText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeItemRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the knowledge item
        /// </param>
        /// <param name="description">
        /// Description of the knowledge item
        /// </param>
        /// <param name="sourceType">
        /// Type of knowledge source
        /// </param>
        /// <param name="url">
        /// Required when source_type is url
        /// </param>
        /// <param name="rawText">
        /// Required when source_type is text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeItemRequest(
            string title,
            string description,
            global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType sourceType,
            string? url,
            string? rawText)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SourceType = sourceType;
            this.Url = url;
            this.RawText = rawText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeItemRequest" /> class.
        /// </summary>
        public CreateKnowledgeItemRequest()
        {
        }

    }
}