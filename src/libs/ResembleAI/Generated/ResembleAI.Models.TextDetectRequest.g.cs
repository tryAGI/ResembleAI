
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextDetectRequest
    {
        /// <summary>
        /// The text to analyze. Must contain at least 25 words (whitespace-delimited) and at most 100,000 characters. Shorter passages are rejected with a 400 because no threshold reliably separates casual human writing from AI-generated text below that length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// How much reasoning effort the detector spends on the passage. Higher levels can improve accuracy on ambiguous text at the cost of latency.<br/>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.TextDetectRequestThinkingJsonConverter))]
        public global::ResembleAI.TextDetectRequestThinking? Thinking { get; set; }

        /// <summary>
        /// Probability cutoff used to turn the AI-likelihood score into the `ai` or `human` prediction. Scores at or above the threshold are reported as `ai`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// POST destination for the result once processing finishes. The body matches the response of `GET /text_detect/{uuid}` with an additional top-level `error` field when analysis failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDetectRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to analyze. Must contain at least 25 words (whitespace-delimited) and at most 100,000 characters. Shorter passages are rejected with a 400 because no threshold reliably separates casual human writing from AI-generated text below that length.
        /// </param>
        /// <param name="thinking">
        /// How much reasoning effort the detector spends on the passage. Higher levels can improve accuracy on ambiguous text at the cost of latency.<br/>
        /// Default Value: low
        /// </param>
        /// <param name="threshold">
        /// Probability cutoff used to turn the AI-likelihood score into the `ai` or `human` prediction. Scores at or above the threshold are reported as `ai`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /text_detect/{uuid}` with an additional top-level `error` field when analysis failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextDetectRequest(
            string text,
            global::ResembleAI.TextDetectRequestThinking? thinking,
            double? threshold,
            string? callbackUrl)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Thinking = thinking;
            this.Threshold = threshold;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDetectRequest" /> class.
        /// </summary>
        public TextDetectRequest()
        {
        }

    }
}