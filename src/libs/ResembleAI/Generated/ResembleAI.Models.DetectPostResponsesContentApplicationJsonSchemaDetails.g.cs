
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectPostResponsesContentApplicationJsonSchemaDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_cost_cents")]
        public double? EstimatedCostCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_cost_cents")]
        public double? DetectCostCents { get; set; }

        /// <summary>
        /// Present only when `detect_watermark=true` was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_cost_cents")]
        public double? WatermarkCostCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaDetails" /> class.
        /// </summary>
        /// <param name="estimatedCostCents"></param>
        /// <param name="detectCostCents"></param>
        /// <param name="watermarkCostCents">
        /// Present only when `detect_watermark=true` was requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectPostResponsesContentApplicationJsonSchemaDetails(
            double? estimatedCostCents,
            double? detectCostCents,
            double? watermarkCostCents)
        {
            this.EstimatedCostCents = estimatedCostCents;
            this.DetectCostCents = detectCostCents;
            this.WatermarkCostCents = watermarkCostCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectPostResponsesContentApplicationJsonSchemaDetails" /> class.
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaDetails()
        {
        }

    }
}