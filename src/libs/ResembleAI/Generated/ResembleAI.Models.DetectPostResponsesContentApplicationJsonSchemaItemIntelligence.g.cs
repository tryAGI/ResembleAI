
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Intelligence result when requested
    /// </summary>
    public sealed partial class DetectPostResponsesContentApplicationJsonSchemaItemIntelligence
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusJsonConverter))]
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter))]
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_uuid")]
        public string? DetectUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItemIntelligence" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="detectUuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligence(
            string? uuid,
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus? status,
            string? errorMessage,
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription? description,
            global::System.DateTime? createdAt,
            string? detectUuid)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.DetectUuid = detectUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItemIntelligence" /> class.
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligence()
        {
        }

    }
}