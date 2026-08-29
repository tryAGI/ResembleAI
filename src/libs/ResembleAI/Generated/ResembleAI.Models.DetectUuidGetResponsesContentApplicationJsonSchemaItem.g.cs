
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
        /// Status of the Deepfake Detection job only. A completed Detect has verdict and metrics available, but its Intelligence results may still be processing.
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
        /// Content Credentials (C2PA) verification result for audio, image, and video media. Returned when verification has completed. A fallback verification failure returns `validation_state: Unavailable` and does not fail the detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c2pa_manifest")]
        public global::ResembleAI.DetectC2paManifest? C2paManifest { get; set; }

        /// <summary>
        /// Source tracing results (only returned if audio is labeled fake)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source_tracing")]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing? AudioSourceTracing { get; set; }

        /// <summary>
        /// With experts omitted or false, one completed Intelligence result when available; otherwise, the current processing or failed result. With experts=true, all successfully completed results as an array, or an empty array when none have completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence? Intelligence { get; set; }

        /// <summary>
        /// Which detection modality was requested for this detect. `all` when not specified<br/>
        /// (the default). For a single-modality video detect, the skipped component's metrics<br/>
        /// are absent (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityJsonConverter))]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality? Modality { get; set; }

        /// <summary>
        /// Effective face-only setting for this detect. `true` only for video inputs that<br/>
        /// include visual analysis; `false` for audio, image, and audio-only video detects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_only")]
        public bool? FaceOnly { get; set; }

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
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_deleted_at")]
        public global::System.DateTime? FileDeletedAt { get; set; }

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
        /// <param name="status">
        /// Status of the Deepfake Detection job only. A completed Detect has verdict and metrics available, but its Intelligence results may still be processing.
        /// </param>
        /// <param name="metrics">
        /// Audio detection metrics (for audio and video media types)
        /// </param>
        /// <param name="imageMetrics">
        /// Image detection metrics (for image media type)
        /// </param>
        /// <param name="videoMetrics">
        /// Video detection metrics (for video media type)
        /// </param>
        /// <param name="c2paManifest">
        /// Content Credentials (C2PA) verification result for audio, image, and video media. Returned when verification has completed. A fallback verification failure returns `validation_state: Unavailable` and does not fail the detection.
        /// </param>
        /// <param name="audioSourceTracing">
        /// Source tracing results (only returned if audio is labeled fake)
        /// </param>
        /// <param name="intelligence">
        /// With experts omitted or false, one completed Intelligence result when available; otherwise, the current processing or failed result. With experts=true, all successfully completed results as an array, or an empty array when none have completed successfully.
        /// </param>
        /// <param name="modality">
        /// Which detection modality was requested for this detect. `all` when not specified<br/>
        /// (the default). For a single-modality video detect, the skipped component's metrics<br/>
        /// are absent (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped).
        /// </param>
        /// <param name="faceOnly">
        /// Effective face-only setting for this detect. `true` only for video inputs that<br/>
        /// include visual analysis; `false` for audio, image, and audio-only video detects.
        /// </param>
        /// <param name="url">
        /// URL to the media file. Null when Zero Retention Mode is enabled.
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
        /// <param name="fileDeletedAt">
        /// ISO 8601 timestamp of when the file was purged, or null if not yet deleted
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
            global::ResembleAI.DetectC2paManifest? c2paManifest,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemAudioSourceTracing? audioSourceTracing,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence? intelligence,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemModality? modality,
            bool? faceOnly,
            string? url,
            string? audioUrl,
            string? filename,
            double? duration,
            bool? zeroRetentionMode,
            global::System.DateTime? fileDeletedAt,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.MediaType = mediaType;
            this.Status = status;
            this.Metrics = metrics;
            this.ImageMetrics = imageMetrics;
            this.VideoMetrics = videoMetrics;
            this.C2paManifest = c2paManifest;
            this.AudioSourceTracing = audioSourceTracing;
            this.Intelligence = intelligence;
            this.Modality = modality;
            this.FaceOnly = faceOnly;
            this.Url = url;
            this.AudioUrl = audioUrl;
            this.Filename = filename;
            this.Duration = duration;
            this.ZeroRetentionMode = zeroRetentionMode;
            this.FileDeletedAt = fileDeletedAt;
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