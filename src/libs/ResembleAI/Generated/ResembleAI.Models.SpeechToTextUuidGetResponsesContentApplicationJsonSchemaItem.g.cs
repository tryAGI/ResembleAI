
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter))]
        public global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>? Words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        /// <param name="text"></param>
        /// <param name="words"></param>
        /// <param name="durationSeconds"></param>
        /// <param name="fileUrl"></param>
        /// <param name="query"></param>
        /// <param name="answer"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem(
            global::System.Guid? uuid,
            global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus? status,
            string? text,
            global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems>? words,
            double? durationSeconds,
            string? fileUrl,
            string? query,
            string? answer,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.Text = text;
            this.Words = words;
            this.DurationSeconds = durationSeconds;
            this.FileUrl = fileUrl;
            this.Query = query;
            this.Answer = answer;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItem()
        {
        }
    }
}