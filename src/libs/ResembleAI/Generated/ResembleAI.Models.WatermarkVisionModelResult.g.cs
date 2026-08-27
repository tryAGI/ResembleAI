
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkVisionModelResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter))]
        public global::ResembleAI.WatermarkVisionModelResultModelVersion ModelVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter))]
        public global::ResembleAI.WatermarkVisionModelResultStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Detected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVisionModelResult" /> class.
        /// </summary>
        /// <param name="detected"></param>
        /// <param name="modelVersion"></param>
        /// <param name="status"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkVisionModelResult(
            bool detected,
            global::ResembleAI.WatermarkVisionModelResultModelVersion modelVersion,
            global::ResembleAI.WatermarkVisionModelResultStatus status,
            double? confidence)
        {
            this.ModelVersion = modelVersion;
            this.Status = status;
            this.Detected = detected;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkVisionModelResult" /> class.
        /// </summary>
        public WatermarkVisionModelResult()
        {
        }

    }
}