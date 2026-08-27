
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalCategoryScore
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Single emoji associated with the category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Similarity score from 0 to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCategoryScore" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score">
        /// Similarity score from 0 to 1.
        /// </param>
        /// <param name="icon">
        /// Single emoji associated with the category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCategoryScore(
            string name,
            double score,
            string? icon)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Icon = icon;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCategoryScore" /> class.
        /// </summary>
        public SignalCategoryScore()
        {
        }

    }
}