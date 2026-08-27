
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunDetectAgentInvestigationRequest
    {
        /// <summary>
        /// Primary media to analyze. Required when `url` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Primary media to analyze. Required when `url` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Public media URL to analyze. Required when `file` is omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Question or investigation objective.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Supporting evidence files. Repeat this field for multiple files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evidence[]")]
        public global::System.Collections.Generic.IList<byte[]>? Evidence { get; set; }

        /// <summary>
        /// Additional URLs for the Detect Agent to check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_urls")]
        public string? CheckUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunDetectAgentInvestigationRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="filename">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="url">
        /// Public media URL to analyze. Required when `file` is omitted.
        /// </param>
        /// <param name="query">
        /// Question or investigation objective.
        /// </param>
        /// <param name="evidence">
        /// Supporting evidence files. Repeat this field for multiple files.
        /// </param>
        /// <param name="checkUrls">
        /// Additional URLs for the Detect Agent to check.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunDetectAgentInvestigationRequest(
            byte[]? file,
            string? filename,
            string? url,
            string? query,
            global::System.Collections.Generic.IList<byte[]>? evidence,
            string? checkUrls)
        {
            this.File = file;
            this.Filename = filename;
            this.Url = url;
            this.Query = query;
            this.Evidence = evidence;
            this.CheckUrls = checkUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunDetectAgentInvestigationRequest" /> class.
        /// </summary>
        public RunDetectAgentInvestigationRequest()
        {
        }

    }
}