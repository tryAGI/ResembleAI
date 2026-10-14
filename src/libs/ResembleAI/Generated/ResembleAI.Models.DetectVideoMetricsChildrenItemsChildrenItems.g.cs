
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
        /// Zero-based position of the chunk in the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        /// Chunk start in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// Chunk end in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// How the video, or one chunk of it, was most likely made. Present only on results scored fake (score of 0.5 or higher) and omitted on real results. A probability distribution over every attack type, sorted from most to least likely; the `prob` values sum to 1 and the first entry is the most likely attack. Codes: S0, S1, S2 (generated), V1, V2, V3 (video-to-video), L1-L6 (local edits), F1-F6 (face), X0 (method unknown). Group codes (S0, V3, F6, X0) are never returned as the first entry. New codes may be added in future releases; if you receive a code you don't recognize, show its `name` instead of treating it as an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attack")]
        public global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoAttackTypeItems>? Attack { get; set; }

        /// <summary>
        /// Frame-level detection results
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
        /// <param name="chunkIndex">
        /// Zero-based position of the chunk in the video
        /// </param>
        /// <param name="startTime">
        /// Chunk start in seconds
        /// </param>
        /// <param name="endTime">
        /// Chunk end in seconds
        /// </param>
        /// <param name="children">
        /// Frame-level detection results
        /// </param>
        /// <param name="attack">
        /// How the video, or one chunk of it, was most likely made. Present only on results scored fake (score of 0.5 or higher) and omitted on real results. A probability distribution over every attack type, sorted from most to least likely; the `prob` values sum to 1 and the first entry is the most likely attack. Codes: S0, S1, S2 (generated), V1, V2, V3 (video-to-video), L1-L6 (local edits), F1-F6 (face), X0 (method unknown). Group codes (S0, V3, F6, X0) are never returned as the first entry. New codes may be added in future releases; if you receive a code you don't recognize, show its `name` instead of treating it as an error.
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
            int chunkIndex,
            double startTime,
            double endTime,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoMetricsChildrenItemsChildrenItemsChildrenItems> children,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectVideoAttackTypeItems>? attack)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.Score = score;
            this.Certainty = certainty;
            this.Certainty__ = certainty__ ?? throw new global::System.ArgumentNullException(nameof(certainty__));
            this.ChunkIndex = chunkIndex;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Attack = attack;
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