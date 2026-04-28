
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectUuidGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter))]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusJsonConverter))]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus? Status { get; set; }

        /// <summary>
        /// Audio detection metrics (for audio and video media types)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::ResembleAI.DetectAudioMetrics? Metrics { get; set; }

        /// <summary>
        /// Image detection metrics (for image media type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_metrics")]
        public global::ResembleAI.DetectImageMetrics? ImageMetrics { get; set; }

        /// <summary>
        /// Video detection metrics (for video media type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_metrics")]
        public global::ResembleAI.DetectVideoMetrics? VideoMetrics { get; set; }

        /// <summary>
        /// Source tracing results (only returned if audio is labeled fake)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source_tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>? AudioSourceTracing { get; set; }

        /// <summary>
        /// Intelligence results when requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>? Intelligence { get; set; }

        /// <summary>
        /// URL to the media file. Null when Zero Retention Modeon Modeon Modeon Modeon Modeon Modeon Mode is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Alias of url. Null when Zero Retention Mode is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Whether Zero Retention Mode is enabled for this detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_retention_mode")]
        public bool? ZeroRetentionMode { get; set; }

        /// <summary>
        /// True when Zero Retention Mode is active and media URLs are redacted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_redacted")]
        public bool? MediaRedacted { get; set; }

        /// <summary>
        /// True when the source file has been permanently deleted from storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_deleted")]
        public bool? MediaDeleted { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_deleted_at")]
        public global::System.DateTime? FileDeletedAt { get; set; }

        /// <summary>
        /// Legacy field. May be present on older image/video detects. Ignored for new detections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public string? Pipeline { get; set; }

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
        /// Initializes a new instance of the <see cref="DetectUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="mediaType"></param>
        /// <param name="status"></param>
        /// <param name="metrics">
        /// Audio detection metrics (for audio and video media types)
        /// </param>
        /// <param name="imageMetrics">
        /// Image detection metrics (for image media type)
        /// </param>
        /// <param name="videoMetrics">
        /// Video detection metrics (for video media type)
        /// </param>
        /// <param name="audioSourceTracing">
        /// Source tracing results (only returned if audio is labeled fake)
        /// </param>
        /// <param name="intelligence">
        /// Intelligence results when requested
        /// </param>
        /// <param name="url">
        /// URL to the media file. Null when Zero Retention Modeon Modeon Modeon Modeon Modeon Modeon Mode is enabled.
        /// </param>
        /// <param name="audioUrl">
        /// Alias of url. Null when Zero Retention Mode is enabled.
        /// </param>
        /// <param name="filename">
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Mode is enabled
        /// </param>
        /// <param name="duration"></param>
        /// <param name="zeroRetentionMode">
        /// Whether Zero Retention Mode is enabled for this detect
        /// </param>
        /// <param name="mediaRedacted">
        /// True when Zero Retention Mode is active and media URLs are redacted
        /// </param>
        /// <param name="mediaDeleted">
        /// True when the source file has been permanently deleted from storage
        /// </param>
        /// <param name="fileDeletedAt">
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
        /// </param>
        /// <param name="pipeline">
        /// Legacy field. May be present on older image/video detects. Ignored for new detections.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectUuidGetResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType? mediaType,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus? status,
            global::ResembleAI.DetectAudioMetrics? metrics,
            global::ResembleAI.DetectImageMetrics? imageMetrics,
            global::ResembleAI.DetectVideoMetrics? videoMetrics,
            global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing, object>? audioSourceTracing,
            global::ResembleAI.OneOf<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence, object>? intelligence,
            string? url,
            string? audioUrl,
            string? filename,
            double? duration,
            bool? zeroRetentionMode,
            bool? mediaRedacted,
            bool? mediaDeleted,
            global::System.DateTime? fileDeletedAt,
            string? pipeline,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.MediaType = mediaType;
            this.Status = status;
            this.Metrics = metrics;
            this.ImageMetrics = imageMetrics;
            this.VideoMetrics = videoMetrics;
            this.AudioSourceTracing = audioSourceTracing;
            this.Intelligence = intelligence;
            this.Url = url;
            this.AudioUrl = audioUrl;
            this.Filename = filename;
            this.Duration = duration;
            this.ZeroRetentionMode = zeroRetentionMode;
            this.MediaRedacted = mediaRedacted;
            this.MediaDeleted = mediaDeleted;
            this.FileDeletedAt = fileDeletedAt;
            this.Pipeline = pipeline;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItem()
        {
        }
    }
}