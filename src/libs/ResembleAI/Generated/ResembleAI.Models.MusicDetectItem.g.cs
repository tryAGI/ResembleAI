
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicDetectItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Display name for the detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `processing` until inference returns, `completed` once `metrics` is populated, or `failed` if the analysis errored. Failed analyses are not billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.MusicDetectItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.MusicDetectItemStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.MusicDetectItemMediaTypeJsonConverter))]
        public global::ResembleAI.MusicDetectItemMediaType MediaType { get; set; }

        /// <summary>
        /// Music detection verdict. Empty while the detection is processing or when it failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::ResembleAI.MusicDetectMetrics? Metrics { get; set; }

        /// <summary>
        /// Duration of the submitted audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// URL to the stored audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Original filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Reason the analysis failed. Null unless `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Request metadata. Music detections always include `detector` set to `music`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public global::ResembleAI.MusicDetectItemExtraParams? ExtraParams { get; set; }

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
        /// Initializes a new instance of the <see cref="MusicDetectItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status">
        /// `processing` until inference returns, `completed` once `metrics` is populated, or `failed` if the analysis errored. Failed analyses are not billed.
        /// </param>
        /// <param name="name">
        /// Display name for the detection.
        /// </param>
        /// <param name="mediaType"></param>
        /// <param name="metrics">
        /// Music detection verdict. Empty while the detection is processing or when it failed.
        /// </param>
        /// <param name="duration">
        /// Duration of the submitted audio in seconds.
        /// </param>
        /// <param name="url">
        /// URL to the stored audio file.
        /// </param>
        /// <param name="filename">
        /// Original filename.
        /// </param>
        /// <param name="errorMessage">
        /// Reason the analysis failed. Null unless `status` is `failed`.
        /// </param>
        /// <param name="extraParams">
        /// Request metadata. Music detections always include `detector` set to `music`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicDetectItem(
            string uuid,
            global::ResembleAI.MusicDetectItemStatus status,
            string? name,
            global::ResembleAI.MusicDetectItemMediaType mediaType,
            global::ResembleAI.MusicDetectMetrics? metrics,
            double? duration,
            string? url,
            string? filename,
            string? errorMessage,
            global::ResembleAI.MusicDetectItemExtraParams? extraParams,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.Name = name;
            this.Status = status;
            this.MediaType = mediaType;
            this.Metrics = metrics;
            this.Duration = duration;
            this.Url = url;
            this.Filename = filename;
            this.ErrorMessage = errorMessage;
            this.ExtraParams = extraParams;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicDetectItem" /> class.
        /// </summary>
        public MusicDetectItem()
        {
        }

    }
}