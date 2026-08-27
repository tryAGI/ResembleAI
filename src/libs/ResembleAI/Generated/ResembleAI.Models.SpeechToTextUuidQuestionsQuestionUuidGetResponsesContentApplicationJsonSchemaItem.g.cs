
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_uuid")]
        public global::System.Guid? TranscriptUuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="transcriptUuid"></param>
        /// <param name="query"></param>
        /// <param name="answer"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem(
            global::System.Guid? uuid,
            global::System.Guid? transcriptUuid,
            string? query,
            string? answer,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.TranscriptUuid = transcriptUuid;
            this.Query = query;
            this.Answer = answer;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public SpeechToTextUuidQuestionsQuestionUuidGetResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}