
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Compact result summary derived from the investigation transcript.
    /// </summary>
    public sealed partial class DetectAgentRunResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectAgentRunResultVerdict, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.DetectAgentRunResultVerdict, object>? Verdict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended_action")]
        public string? RecommendedAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ran")]
        public bool? AgentRan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunResult" /> class.
        /// </summary>
        /// <param name="verdict"></param>
        /// <param name="recommendedAction"></param>
        /// <param name="confidence"></param>
        /// <param name="label"></param>
        /// <param name="score"></param>
        /// <param name="agentRan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentRunResult(
            global::ResembleAI.OneOf<global::ResembleAI.DetectAgentRunResultVerdict, object>? verdict,
            string? recommendedAction,
            double? confidence,
            string? label,
            double? score,
            bool? agentRan)
        {
            this.Verdict = verdict;
            this.RecommendedAction = recommendedAction;
            this.Confidence = confidence;
            this.Label = label;
            this.Score = score;
            this.AgentRan = agentRan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunResult" /> class.
        /// </summary>
        public DetectAgentRunResult()
        {
        }

    }
}