
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detected")]
        public bool? Detected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alterations")]
        public string? Alterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered" /> class.
        /// </summary>
        /// <param name="detected"></param>
        /// <param name="confidence"></param>
        /// <param name="alterations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered(
            bool? detected,
            double? confidence,
            string? alterations)
        {
            this.Detected = detected;
            this.Confidence = confidence;
            this.Alterations = alterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered" /> class.
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionOneOf1DigitallyAltered()
        {
        }

    }
}