
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio detection metrics (for audio and video media types)
    /// </summary>
    public sealed partial class DetectAudioMetrics
    {
        /// <summary>
        /// Detection label (fake or real)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Array of prediction scores per chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Score { get; set; }

        /// <summary>
        /// Consistency metric across chunks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Consistency { get; set; }

        /// <summary>
        /// Overall aggregated detection score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregated_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AggregatedScore { get; set; }

        /// <summary>
        /// URL to visualization heatmap image (if visualize=true)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAudioMetrics" /> class.
        /// </summary>
        /// <param name="label">
        /// Detection label (fake or real)
        /// </param>
        /// <param name="score">
        /// Array of prediction scores per chunk
        /// </param>
        /// <param name="consistency">
        /// Consistency metric across chunks
        /// </param>
        /// <param name="aggregatedScore">
        /// Overall aggregated detection score
        /// </param>
        /// <param name="image">
        /// URL to visualization heatmap image (if visualize=true)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAudioMetrics(
            string label,
            global::System.Collections.Generic.IList<string> score,
            string consistency,
            string aggregatedScore,
            string? image)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
            this.Consistency = consistency ?? throw new global::System.ArgumentNullException(nameof(consistency));
            this.AggregatedScore = aggregatedScore ?? throw new global::System.ArgumentNullException(nameof(aggregatedScore));
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAudioMetrics" /> class.
        /// </summary>
        public DetectAudioMetrics()
        {
        }

    }
}