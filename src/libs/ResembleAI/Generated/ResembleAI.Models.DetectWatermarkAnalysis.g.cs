
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Conditional watermark analysis requested with `detect_watermark=true`. The object is omitted when watermark analysis was not requested. Resemble watermark metrics and the optional SynthID verdict are independent of the deepfake verdict.
    /// </summary>
    public sealed partial class DetectWatermarkAnalysis
    {
        /// <summary>
        /// Lifecycle state of the linked watermark analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectWatermarkAnalysisStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectWatermarkAnalysisStatus Status { get; set; }

        /// <summary>
        /// Present when watermark analysis completes. Audio uses Perth v1/v2 metrics; image and video use the Resemble image/video detector metrics. `synthid`, when present, is the boolean verdict returned by SynthID. Its omission means the provider result was unavailable, not that no watermark was found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectWatermarkAnalysisMetricsJsonConverter))]
        public global::ResembleAI.DetectWatermarkAnalysisMetrics? Metrics { get; set; }

        /// <summary>
        /// Safe error message when the watermark analysis failed. A child failure does not fail an otherwise successful deepfake detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkAnalysis" /> class.
        /// </summary>
        /// <param name="status">
        /// Lifecycle state of the linked watermark analysis.
        /// </param>
        /// <param name="metrics">
        /// Present when watermark analysis completes. Audio uses Perth v1/v2 metrics; image and video use the Resemble image/video detector metrics. `synthid`, when present, is the boolean verdict returned by SynthID. Its omission means the provider result was unavailable, not that no watermark was found.
        /// </param>
        /// <param name="errorMessage">
        /// Safe error message when the watermark analysis failed. A child failure does not fail an otherwise successful deepfake detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectWatermarkAnalysis(
            global::ResembleAI.DetectWatermarkAnalysisStatus status,
            global::ResembleAI.DetectWatermarkAnalysisMetrics? metrics,
            string? errorMessage)
        {
            this.Status = status;
            this.Metrics = metrics;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkAnalysis" /> class.
        /// </summary>
        public DetectWatermarkAnalysis()
        {
        }

    }
}