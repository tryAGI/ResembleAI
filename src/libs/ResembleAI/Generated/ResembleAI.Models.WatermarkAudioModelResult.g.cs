
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WatermarkAudioModelResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkAudioModelResultModelVersion ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkAudioModelResultStatus Status { get; set; }

        /// <summary>
        /// Null when this detector was unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected")]
        public bool? Detected { get; set; }

        /// <summary>
        /// Successful per-channel detection results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_watermark")]
        public global::System.Collections.Generic.Dictionary<string, bool>? HasWatermark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Safe error message when status is failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAudioModelResult" /> class.
        /// </summary>
        /// <param name="modelVersion"></param>
        /// <param name="status"></param>
        /// <param name="detected">
        /// Null when this detector was unavailable.
        /// </param>
        /// <param name="hasWatermark">
        /// Successful per-channel detection results.
        /// </param>
        /// <param name="confidence"></param>
        /// <param name="error">
        /// Safe error message when status is failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkAudioModelResult(
            global::ResembleAI.WatermarkAudioModelResultModelVersion modelVersion,
            global::ResembleAI.WatermarkAudioModelResultStatus status,
            bool? detected,
            global::System.Collections.Generic.Dictionary<string, bool>? hasWatermark,
            double? confidence,
            string? error)
        {
            this.ModelVersion = modelVersion;
            this.Status = status;
            this.Detected = detected;
            this.HasWatermark = hasWatermark;
            this.Confidence = confidence;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkAudioModelResult" /> class.
        /// </summary>
        public WatermarkAudioModelResult()
        {
        }

    }
}