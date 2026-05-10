
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Detection results. For audio, has_watermark is a per-channel object. For image/video, has_watermark is a boolean.
    /// </summary>
    public sealed partial class WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_watermark")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkJsonConverter))]
        public global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark? HasWatermark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics" /> class.
        /// </summary>
        /// <param name="hasWatermark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics(
            global::ResembleAI.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark? hasWatermark)
        {
            this.HasWatermark = hasWatermark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics" /> class.
        /// </summary>
        public WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetrics()
        {
        }

    }
}