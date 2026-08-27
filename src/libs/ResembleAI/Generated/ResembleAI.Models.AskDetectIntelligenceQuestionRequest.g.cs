
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AskDetectIntelligenceQuestionRequest
    {
        /// <summary>
        /// The natural-language question to ask about the detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AskDetectIntelligenceQuestionRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The natural-language question to ask about the detection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AskDetectIntelligenceQuestionRequest(
            string query)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AskDetectIntelligenceQuestionRequest" /> class.
        /// </summary>
        public AskDetectIntelligenceQuestionRequest()
        {
        }

    }
}