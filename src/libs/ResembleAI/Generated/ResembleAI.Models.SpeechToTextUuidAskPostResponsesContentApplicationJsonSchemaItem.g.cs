
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="transcriptUuid"></param>
        /// <param name="query"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem(
            global::System.Guid? uuid,
            global::System.Guid? transcriptUuid,
            string? query,
            string? status,
            global::System.DateTime? createdAt)
        {
            this.Uuid = uuid;
            this.TranscriptUuid = transcriptUuid;
            this.Query = query;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public SpeechToTextUuidAskPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}