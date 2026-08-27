
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalScoreItem
    {
        /// <summary>
        /// Submission identifier, used with `DELETE /signal/{id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.SignalScoreItemInputModality InputModality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.SignalScoreItemVerdict Verdict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_category")]
        public global::ResembleAI.SignalCategoryScore? TopCategory { get; set; }

        /// <summary>
        /// Highest-scoring categories, including the top category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalCategoryScore>? CategoryScores { get; set; }

        /// <summary>
        /// How strongly the content matched benign, non-fraud content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benign_score")]
        public double? BenignScore { get; set; }

        /// <summary>
        /// Gap between the top category score and the runner-up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_over_second")]
        public double? MarginOverSecond { get; set; }

        /// <summary>
        /// Sample phrases from the top category, useful for explaining the verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<string>? Examples { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_matches")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalTopMatch>? TopMatches { get; set; }

        /// <summary>
        /// Media duration for audio and video. Null for text and image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalScoreItem" /> class.
        /// </summary>
        /// <param name="inputModality"></param>
        /// <param name="verdict"></param>
        /// <param name="id">
        /// Submission identifier, used with `DELETE /signal/{id}`.
        /// </param>
        /// <param name="topCategory"></param>
        /// <param name="categoryScores">
        /// Highest-scoring categories, including the top category.
        /// </param>
        /// <param name="benignScore">
        /// How strongly the content matched benign, non-fraud content.
        /// </param>
        /// <param name="marginOverSecond">
        /// Gap between the top category score and the runner-up.
        /// </param>
        /// <param name="examples">
        /// Sample phrases from the top category, useful for explaining the verdict.
        /// </param>
        /// <param name="topMatches"></param>
        /// <param name="durationSeconds">
        /// Media duration for audio and video. Null for text and image.
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalScoreItem(
            global::ResembleAI.SignalScoreItemInputModality inputModality,
            global::ResembleAI.SignalScoreItemVerdict verdict,
            int? id,
            global::ResembleAI.SignalCategoryScore? topCategory,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalCategoryScore>? categoryScores,
            double? benignScore,
            double? marginOverSecond,
            global::System.Collections.Generic.IList<string>? examples,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalTopMatch>? topMatches,
            double? durationSeconds,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.InputModality = inputModality;
            this.Verdict = verdict;
            this.TopCategory = topCategory;
            this.CategoryScores = categoryScores;
            this.BenignScore = benignScore;
            this.MarginOverSecond = marginOverSecond;
            this.Examples = examples;
            this.TopMatches = topMatches;
            this.DurationSeconds = durationSeconds;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalScoreItem" /> class.
        /// </summary>
        public SignalScoreItem()
        {
        }

    }
}