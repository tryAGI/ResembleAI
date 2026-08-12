
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectAgentsListDetectAgentInvestigationRunsResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.DetectAgentRunSummary> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentsListDetectAgentInvestigationRunsResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentsListDetectAgentInvestigationRunsResponse200(
            bool success,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectAgentRunSummary> items,
            int count)
        {
            this.Success = success;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentsListDetectAgentInvestigationRunsResponse200" /> class.
        /// </summary>
        public DetectAgentsListDetectAgentInvestigationRunsResponse200()
        {
        }

    }
}