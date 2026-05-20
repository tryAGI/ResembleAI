
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// UUID of the question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// UUID of the associated detection report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_uuid")]
        public string? DetectUuid { get; set; }

        /// <summary>
        /// The submitted question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The generated answer (null until completed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Current status of the question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusJsonConverter))]
        public global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus? Status { get; set; }

        /// <summary>
        /// Error details when status is failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

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
        /// Initializes a new instance of the <see cref="DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid">
        /// UUID of the question
        /// </param>
        /// <param name="detectUuid">
        /// UUID of the associated detection report
        /// </param>
        /// <param name="query">
        /// The submitted question
        /// </param>
        /// <param name="answer">
        /// The generated answer (null until completed)
        /// </param>
        /// <param name="status">
        /// Current status of the question
        /// </param>
        /// <param name="errorMessage">
        /// Error details when status is failed
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            string? detectUuid,
            string? query,
            string? answer,
            global::ResembleAI.DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus? status,
            string? errorMessage,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.DetectUuid = detectUuid;
            this.Query = query;
            this.Answer = answer;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}