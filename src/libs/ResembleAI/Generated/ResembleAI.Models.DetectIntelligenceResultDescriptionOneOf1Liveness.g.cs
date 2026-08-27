
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectIntelligenceResultDescriptionOneOf1Liveness
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assessment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1LivenessAssessmentJsonConverter))]
        public global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment? Assessment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indicators")]
        public string? Indicators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectIntelligenceResultDescriptionOneOf1Liveness" /> class.
        /// </summary>
        /// <param name="assessment"></param>
        /// <param name="confidence"></param>
        /// <param name="indicators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectIntelligenceResultDescriptionOneOf1Liveness(
            global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1LivenessAssessment? assessment,
            double? confidence,
            string? indicators)
        {
            this.Assessment = assessment;
            this.Confidence = confidence;
            this.Indicators = indicators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectIntelligenceResultDescriptionOneOf1Liveness" /> class.
        /// </summary>
        public DetectIntelligenceResultDescriptionOneOf1Liveness()
        {
        }

    }
}