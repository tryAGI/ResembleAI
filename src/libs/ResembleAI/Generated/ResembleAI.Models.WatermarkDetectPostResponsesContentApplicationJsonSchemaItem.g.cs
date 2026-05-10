
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkDetectPostResponsesContentApplicationJsonSchemaItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter))]
        public global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_media_url")]
        public string? SourceMediaUrl { get; set; }

        /// <summary>
        /// Detection results. Null while processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics, object>? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked_media")]
        public string? WatermarkedMedia { get; set; }

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
        /// Initializes a new instance of the <see cref="WatermarkDetectPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="mediaType"></param>
        /// <param name="sourceMediaUrl"></param>
        /// <param name="metrics">
        /// Detection results. Null while processing.
        /// </param>
        /// <param name="watermarkedMedia"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkDetectPostResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType? mediaType,
            string? sourceMediaUrl,
            global::ResembleAI.OneOf<global::ResembleAI.WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMetrics, object>? metrics,
            string? watermarkedMedia,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.MediaType = mediaType;
            this.SourceMediaUrl = sourceMediaUrl;
            this.Metrics = metrics;
            this.WatermarkedMedia = watermarkedMedia;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public WatermarkDetectPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}