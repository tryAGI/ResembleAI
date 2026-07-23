
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkDetectItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkDetectItemMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter))]
        public global::ResembleAI.WatermarkDetectItemOperationType OperationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkDetectItemStatus Status { get; set; }

        /// <summary>
        /// Present for image/video. Audio versions are reported in metrics.model_results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter))]
        public global::ResembleAI.WatermarkDetectItemModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_media_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceMediaUrl { get; set; }

        /// <summary>
        /// Null while processing. New results use the media-specific versioned schema; historical audio results can use a flat shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectItemMetrics?, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectItemMetrics?, object>? Metrics { get; set; }

        /// <summary>
        /// Detection does not produce output media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked_media")]
        public string? WatermarkedMedia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="mediaType"></param>
        /// <param name="status"></param>
        /// <param name="sourceMediaUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="operationType"></param>
        /// <param name="modelVersion">
        /// Present for image/video. Audio versions are reported in metrics.model_results.
        /// </param>
        /// <param name="metrics">
        /// Null while processing. New results use the media-specific versioned schema; historical audio results can use a flat shape.
        /// </param>
        /// <param name="watermarkedMedia">
        /// Detection does not produce output media.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkDetectItem(
            string uuid,
            global::ResembleAI.WatermarkDetectItemMediaType mediaType,
            global::ResembleAI.WatermarkDetectItemStatus status,
            string sourceMediaUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::ResembleAI.WatermarkDetectItemOperationType operationType,
            global::ResembleAI.WatermarkDetectItemModelVersion? modelVersion,
            global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectItemMetrics?, object>? metrics,
            string? watermarkedMedia)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.MediaType = mediaType;
            this.OperationType = operationType;
            this.Status = status;
            this.ModelVersion = modelVersion;
            this.SourceMediaUrl = sourceMediaUrl ?? throw new global::System.ArgumentNullException(nameof(sourceMediaUrl));
            this.Metrics = metrics;
            this.WatermarkedMedia = watermarkedMedia;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectItem" /> class.
        /// </summary>
        public WatermarkDetectItem()
        {
        }

    }
}