
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkApplyPostResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Detected media type of the source file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter))]
        public global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType? MediaType { get; set; }

        /// <summary>
        /// The original source URL provided in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_media_url")]
        public string? SourceMediaUrl { get; set; }

        /// <summary>
        /// Signed URL to the watermarked file. Populated when processing is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarked_media")]
        public string? WatermarkedMedia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics, object>? Metrics { get; set; }

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
        /// Initializes a new instance of the <see cref="WatermarkApplyPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="mediaType">
        /// Detected media type of the source file.
        /// </param>
        /// <param name="sourceMediaUrl">
        /// The original source URL provided in the request.
        /// </param>
        /// <param name="watermarkedMedia">
        /// Signed URL to the watermarked file. Populated when processing is complete.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkApplyPostResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType? mediaType,
            string? sourceMediaUrl,
            string? watermarkedMedia,
            global::ResembleAI.OneOf<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMetrics, object>? metrics,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.MediaType = mediaType;
            this.SourceMediaUrl = sourceMediaUrl;
            this.WatermarkedMedia = watermarkedMedia;
            this.Metrics = metrics;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public WatermarkApplyPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}