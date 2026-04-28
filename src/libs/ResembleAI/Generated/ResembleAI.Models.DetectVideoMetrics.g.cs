
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Video detection metrics (for video media type)
    /// </summary>
    public sealed partial class DetectVideoMetrics
    {
        /// <summary>
        /// Overall video detection label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Overall detection score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Overall certainty score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certainty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Certainty { get; set; }

        /// <summary>
        /// Optional tree visualization data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("treeview")]
        public string? Treeview { get; set; }

        /// <summary>
        /// Hierarchical detection results across frames
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItems> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetrics" /> class.
        /// </summary>
        /// <param name="label">
        /// Overall video detection label
        /// </param>
        /// <param name="score">
        /// Overall detection score
        /// </param>
        /// <param name="certainty">
        /// Overall certainty score
        /// </param>
        /// <param name="children">
        /// Hierarchical detection results across frames
        /// </param>
        /// <param name="treeview">
        /// Optional tree visualization data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectVideoMetrics(
            string label,
            double score,
            double certainty,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItems> children,
            string? treeview)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
            this.Certainty = certainty;
            this.Treeview = treeview;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetrics" /> class.
        /// </summary>
        public DetectVideoMetrics()
        {
        }
    }
}