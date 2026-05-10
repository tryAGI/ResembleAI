
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Image detection metrics (for image media type)
    /// </summary>
    public sealed partial class DetectImageMetrics
    {
        /// <summary>
        /// Type of image analysis performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Detection label (fake or real)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// URL to visualization image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Detection confidence score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Nested analysis results (structure varies by pipeline)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.DetectImageMetricsChildrenItems> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectImageMetrics" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of image analysis performed
        /// </param>
        /// <param name="label">
        /// Detection label (fake or real)
        /// </param>
        /// <param name="image">
        /// URL to visualization image
        /// </param>
        /// <param name="score">
        /// Detection confidence score
        /// </param>
        /// <param name="children">
        /// Nested analysis results (structure varies by pipeline)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectImageMetrics(
            string type,
            string label,
            string image,
            double score,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectImageMetricsChildrenItems> children)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Score = score;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectImageMetrics" /> class.
        /// </summary>
        public DetectImageMetrics()
        {
        }

    }
}