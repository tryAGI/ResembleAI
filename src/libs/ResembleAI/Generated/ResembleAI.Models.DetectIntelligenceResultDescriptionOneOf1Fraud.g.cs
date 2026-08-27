
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectIntelligenceResultDescriptionOneOf1Fraud
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectIntelligenceResultDescriptionOneOf1FraudTypeJsonConverter))]
        public global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectIntelligenceResultDescriptionOneOf1Fraud" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="confidence"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectIntelligenceResultDescriptionOneOf1Fraud(
            global::ResembleAI.DetectIntelligenceResultDescriptionOneOf1FraudType? type,
            double? confidence,
            string? reasoning)
        {
            this.Type = type;
            this.Confidence = confidence;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectIntelligenceResultDescriptionOneOf1Fraud" /> class.
        /// </summary>
        public DetectIntelligenceResultDescriptionOneOf1Fraud()
        {
        }

    }
}