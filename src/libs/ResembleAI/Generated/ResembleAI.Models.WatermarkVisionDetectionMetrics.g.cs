
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkVisionDetectionMetrics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus OverallStatus { get; set; }

        /// <summary>
        /// Contains perth_v2 only when watermark signal is detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected_model_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems> DetectedModelVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_watermark")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasWatermark { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_score")]
        public double? DetectionScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionModelResult> ModelResults { get; set; }

        /// <summary>
        /// Backward-compatible image/video verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        public global::ResembleAI.WatermarkVisionDetectionMetricsVerdict? Verdict { get; set; }

        /// <summary>
        /// Optional auxiliary SynthID signal for images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthid")]
        public bool? Synthid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVisionDetectionMetrics" /> class.
        /// </summary>
        /// <param name="overallStatus"></param>
        /// <param name="detectedModelVersions">
        /// Contains perth_v2 only when watermark signal is detected.
        /// </param>
        /// <param name="hasWatermark"></param>
        /// <param name="modelResults"></param>
        /// <param name="detectionScore"></param>
        /// <param name="verdict">
        /// Backward-compatible image/video verdict.
        /// </param>
        /// <param name="synthid">
        /// Optional auxiliary SynthID signal for images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkVisionDetectionMetrics(
            global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus overallStatus,
            global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems> detectedModelVersions,
            bool hasWatermark,
            global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionModelResult> modelResults,
            double? detectionScore,
            global::ResembleAI.WatermarkVisionDetectionMetricsVerdict? verdict,
            bool? synthid)
        {
            this.OverallStatus = overallStatus;
            this.DetectedModelVersions = detectedModelVersions ?? throw new global::System.ArgumentNullException(nameof(detectedModelVersions));
            this.HasWatermark = hasWatermark;
            this.DetectionScore = detectionScore;
            this.ModelResults = modelResults ?? throw new global::System.ArgumentNullException(nameof(modelResults));
            this.Verdict = verdict;
            this.Synthid = synthid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVisionDetectionMetrics" /> class.
        /// </summary>
        public WatermarkVisionDetectionMetrics()
        {
        }

    }
}