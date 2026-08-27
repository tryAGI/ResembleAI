
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkAudioDetectionMetrics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus OverallStatus { get; set; }

        /// <summary>
        /// Only model versions that positively detected a watermark.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected_model_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems> DetectedModelVersions { get; set; }

        /// <summary>
        /// True only when both audio detectors completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage_complete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CoverageComplete { get; set; }

        /// <summary>
        /// Per-channel aggregate across successful audio detectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_watermark")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, bool> HasWatermark { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioModelResult> ModelResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAudioDetectionMetrics" /> class.
        /// </summary>
        /// <param name="overallStatus"></param>
        /// <param name="detectedModelVersions">
        /// Only model versions that positively detected a watermark.
        /// </param>
        /// <param name="coverageComplete">
        /// True only when both audio detectors completed successfully.
        /// </param>
        /// <param name="hasWatermark">
        /// Per-channel aggregate across successful audio detectors.
        /// </param>
        /// <param name="modelResults"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkAudioDetectionMetrics(
            global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus overallStatus,
            global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems> detectedModelVersions,
            bool coverageComplete,
            global::System.Collections.Generic.Dictionary<string, bool> hasWatermark,
            global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioModelResult> modelResults,
            double? confidence)
        {
            this.OverallStatus = overallStatus;
            this.DetectedModelVersions = detectedModelVersions ?? throw new global::System.ArgumentNullException(nameof(detectedModelVersions));
            this.CoverageComplete = coverageComplete;
            this.HasWatermark = hasWatermark ?? throw new global::System.ArgumentNullException(nameof(hasWatermark));
            this.Confidence = confidence;
            this.ModelResults = modelResults ?? throw new global::System.ArgumentNullException(nameof(modelResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAudioDetectionMetrics" /> class.
        /// </summary>
        public WatermarkAudioDetectionMetrics()
        {
        }

    }
}