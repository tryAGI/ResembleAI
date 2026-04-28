
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="conclusion"></param>
        /// <param name="score"></param>
        /// <param name="certainty"></param>
        /// <param name="certainty__"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems(
            string type,
            string conclusion,
            double score,
            double certainty,
            string certainty__)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.Score = score;
            this.Certainty = certainty;
            this.Certainty__ = certainty__ ?? throw new global::System.ArgumentNullException(nameof(certainty__));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems" /> class.
        /// </summary>
        public DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems()
        {
        }
    }
}