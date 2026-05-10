
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectVideoMetricsChildrenItemsChildrenItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certainty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Certainty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certainty (%)")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Certainty__ { get; set; }

        /// <summary>
        /// Timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Segment-level detection results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetricsChildrenItemsChildrenItems" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="conclusion"></param>
        /// <param name="score"></param>
        /// <param name="certainty"></param>
        /// <param name="certainty__"></param>
        /// <param name="timestamp">
        /// Timestamp in seconds
        /// </param>
        /// <param name="children">
        /// Segment-level detection results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectVideoMetricsChildrenItemsChildrenItems(
            string type,
            string conclusion,
            double score,
            double certainty,
            string certainty__,
            double timestamp,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems> children)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.Score = score;
            this.Certainty = certainty;
            this.Certainty__ = certainty__ ?? throw new global::System.ArgumentNullException(nameof(certainty__));
            this.Timestamp = timestamp;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetricsChildrenItemsChildrenItems" /> class.
        /// </summary>
        public DetectVideoMetricsChildrenItemsChildrenItems()
        {
        }

    }
}