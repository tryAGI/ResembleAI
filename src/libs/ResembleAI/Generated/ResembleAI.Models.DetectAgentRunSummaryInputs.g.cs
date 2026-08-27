
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Submitted investigation inputs. Null-valued fields are omitted.
    /// </summary>
    public sealed partial class DetectAgentRunSummaryInputs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_urls")]
        public string? CheckUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunSummaryInputs" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        /// <param name="checkUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentRunSummaryInputs(
            string? query,
            string? url,
            string? filename,
            string? checkUrls)
        {
            this.Query = query;
            this.Url = url;
            this.Filename = filename;
            this.CheckUrls = checkUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRunSummaryInputs" /> class.
        /// </summary>
        public DetectAgentRunSummaryInputs()
        {
        }

    }
}