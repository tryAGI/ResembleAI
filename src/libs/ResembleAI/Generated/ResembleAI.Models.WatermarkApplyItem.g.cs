
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkApplyItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Detected media type of the source file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkApplyItemMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter))]
        public global::ResembleAI.WatermarkApplyItemOperationType OperationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkApplyItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter))]
        public global::ResembleAI.WatermarkApplyItemModelVersion ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_media_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceMediaUrl { get; set; }

        /// <summary>
        /// Signed output URL when processing is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked_media")]
        public string? WatermarkedMedia { get; set; }

        /// <summary>
        /// Apply metadata for image/video. Audio apply metrics are null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::ResembleAI.WatermarkApplyMetrics? Metrics { get; set; }

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
        /// Initializes a new instance of the <see cref="WatermarkApplyItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="mediaType">
        /// Detected media type of the source file.
        /// </param>
        /// <param name="status"></param>
        /// <param name="sourceMediaUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="operationType"></param>
        /// <param name="modelVersion"></param>
        /// <param name="watermarkedMedia">
        /// Signed output URL when processing is complete.
        /// </param>
        /// <param name="metrics">
        /// Apply metadata for image/video. Audio apply metrics are null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkApplyItem(
            string uuid,
            global::ResembleAI.WatermarkApplyItemMediaType mediaType,
            global::ResembleAI.WatermarkApplyItemStatus status,
            string sourceMediaUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::ResembleAI.WatermarkApplyItemOperationType operationType,
            global::ResembleAI.WatermarkApplyItemModelVersion modelVersion,
            string? watermarkedMedia,
            global::ResembleAI.WatermarkApplyMetrics? metrics)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.MediaType = mediaType;
            this.OperationType = operationType;
            this.Status = status;
            this.ModelVersion = modelVersion;
            this.SourceMediaUrl = sourceMediaUrl ?? throw new global::System.ArgumentNullException(nameof(sourceMediaUrl));
            this.WatermarkedMedia = watermarkedMedia;
            this.Metrics = metrics;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyItem" /> class.
        /// </summary>
        public WatermarkApplyItem()
        {
        }

    }
}