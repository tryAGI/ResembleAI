
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectPostResponsesContentApplicationJsonSchemaItem
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
        public string? Status { get; set; }

        /// <summary>
        /// Whether Zero Retention Mode is enabled for this detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_retention_mode")]
        public bool? ZeroRetentionMode { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_deleted_at")]
        public global::System.DateTime? FileDeletedAt { get; set; }

        /// <summary>
        /// URL to the media file. Null when Zero Retention Mode is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Alias of url. Null when Zero Retention Mode is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Modeon Modeon Mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Intelligence results when requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>? Intelligence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        /// <param name="zeroRetentionMode">
        /// Whether Zero Retention Mode is enabled for this detect
        /// </param>
        /// <param name="fileDeletedAt">
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
        /// </param>
        /// <param name="url">
        /// URL to the media file. Null when Zero Retention Mode is enabled.
        /// </param>
        /// <param name="audioUrl">
        /// Alias of url. Null when Zero Retention Mode is enabled.
        /// </param>
        /// <param name="filename">
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Modeon Modeon Mode is enabled
        /// </param>
        /// <param name="intelligence">
        /// Intelligence results when requested
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectPostResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            string? status,
            bool? zeroRetentionMode,
            global::System.DateTime? fileDeletedAt,
            string? url,
            string? audioUrl,
            string? filename,
            global::ResembleAI.OneOf<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence, object>? intelligence)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.ZeroRetentionMode = zeroRetentionMode;
            this.FileDeletedAt = fileDeletedAt;
            this.Url = url;
            this.AudioUrl = audioUrl;
            this.Filename = filename;
            this.Intelligence = intelligence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}