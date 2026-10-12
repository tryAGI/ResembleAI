
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Music detection verdict. Empty while the detection is processing or when it failed.
    /// </summary>
    public sealed partial class MusicDetectMetrics
    {
        /// <summary>
        /// `fake` when the track is classified as AI-generated music, `real` when it is classified as human-produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.MusicDetectMetricsLabelJsonConverter))]
        public global::ResembleAI.MusicDetectMetricsLabel? Label { get; set; }

        /// <summary>
        /// Overall likelihood that the track is AI-generated, from 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregated_score")]
        public double? AggregatedScore { get; set; }

        /// <summary>
        /// Per-window likelihood that the audio is AI-generated, from 0 to 1. A window that could not be scored (for example, silence) is `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::System.Collections.Generic.IList<double>? Score { get; set; }

        /// <summary>
        /// Duration of the analyzed audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// How consistent the per-window scores are across the track, from 0 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistency")]
        public double? Consistency { get; set; }

        /// <summary>
        /// Base64-encoded heatmap image. Present only when `visualize` was `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicDetectMetrics" /> class.
        /// </summary>
        /// <param name="label">
        /// `fake` when the track is classified as AI-generated music, `real` when it is classified as human-produced.
        /// </param>
        /// <param name="aggregatedScore">
        /// Overall likelihood that the track is AI-generated, from 0 to 1.
        /// </param>
        /// <param name="score">
        /// Per-window likelihood that the audio is AI-generated, from 0 to 1. A window that could not be scored (for example, silence) is `null`.
        /// </param>
        /// <param name="duration">
        /// Duration of the analyzed audio in seconds.
        /// </param>
        /// <param name="consistency">
        /// How consistent the per-window scores are across the track, from 0 to 100.
        /// </param>
        /// <param name="image">
        /// Base64-encoded heatmap image. Present only when `visualize` was `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicDetectMetrics(
            global::ResembleAI.MusicDetectMetricsLabel? label,
            double? aggregatedScore,
            global::System.Collections.Generic.IList<double>? score,
            double? duration,
            double? consistency,
            string? image)
        {
            this.Label = label;
            this.AggregatedScore = aggregatedScore;
            this.Score = score;
            this.Duration = duration;
            this.Consistency = consistency;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicDetectMetrics" /> class.
        /// </summary>
        public MusicDetectMetrics()
        {
        }

    }
}