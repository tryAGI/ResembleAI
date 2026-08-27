
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalTopMatch
    {
        /// <summary>
        /// Category the matched example belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The individual training example that matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalTopMatch" /> class.
        /// </summary>
        /// <param name="category">
        /// Category the matched example belongs to.
        /// </param>
        /// <param name="text">
        /// The individual training example that matched.
        /// </param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalTopMatch(
            string? category,
            string? text,
            double? score)
        {
            this.Category = category;
            this.Text = text;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalTopMatch" /> class.
        /// </summary>
        public SignalTopMatch()
        {
        }

    }
}