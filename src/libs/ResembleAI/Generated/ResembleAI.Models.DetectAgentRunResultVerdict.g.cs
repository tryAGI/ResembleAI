
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectAgentRunResultVerdict
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpt")]
        public string? Excerpt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunResultVerdict" /> class.
        /// </summary>
        /// <param name="forced"></param>
        /// <param name="excerpt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentRunResultVerdict(
            bool? forced,
            string? excerpt)
        {
            this.Forced = forced;
            this.Excerpt = excerpt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunResultVerdict" /> class.
        /// </summary>
        public DetectAgentRunResultVerdict()
        {
        }

    }
}