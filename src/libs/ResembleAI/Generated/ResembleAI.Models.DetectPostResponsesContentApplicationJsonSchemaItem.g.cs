
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
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Mode is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Which detection modality was requested. `all` when not specified.<br/>
        /// For a single-modality video detect, the skipped component's metrics are absent<br/>
        /// (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped), and the<br/>
        /// detect still reaches `completed` once the requested modality(ies) finish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectPostResponsesContentApplicationJsonSchemaItemModalityJsonConverter))]
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality? Modality { get; set; }

        /// <summary>
        /// Effective face-only setting. `true` only for video inputs that include visual<br/>
        /// analysis; `false` for audio, image, and audio-only video detects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_only")]
        public bool? FaceOnly { get; set; }

        /// <summary>
        /// Default Intelligence result when requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence? Intelligence { get; set; }

        /// <summary>
        /// Content Credentials (C2PA) verification result for audio, image, and video media. Returned when verification has completed. A fallback verification failure returns `validation_state: Unavailable` and does not fail the detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c2pa_manifest")]
        public global::ResembleAI.DetectC2paManifest? C2paManifest { get; set; }

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
        /// Original filename, or tokenized (redacted_&lt;token&gt;.&lt;ext&gt;) when Zero Retention Mode is enabled
        /// </param>
        /// <param name="modality">
        /// Which detection modality was requested. `all` when not specified.<br/>
        /// For a single-modality video detect, the skipped component's metrics are absent<br/>
        /// (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped), and the<br/>
        /// detect still reaches `completed` once the requested modality(ies) finish.
        /// </param>
        /// <param name="faceOnly">
        /// Effective face-only setting. `true` only for video inputs that include visual<br/>
        /// analysis; `false` for audio, image, and audio-only video detects.
        /// </param>
        /// <param name="intelligence">
        /// Default Intelligence result when requested
        /// </param>
        /// <param name="c2paManifest">
        /// Content Credentials (C2PA) verification result for audio, image, and video media. Returned when verification has completed. A fallback verification failure returns `validation_state: Unavailable` and does not fail the detection.
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
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemModality? modality,
            bool? faceOnly,
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligence? intelligence,
            global::ResembleAI.DetectC2paManifest? c2paManifest)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.ZeroRetentionMode = zeroRetentionMode;
            this.FileDeletedAt = fileDeletedAt;
            this.Url = url;
            this.AudioUrl = audioUrl;
            this.Filename = filename;
            this.Modality = modality;
            this.FaceOnly = faceOnly;
            this.Intelligence = intelligence;
            this.C2paManifest = c2paManifest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}