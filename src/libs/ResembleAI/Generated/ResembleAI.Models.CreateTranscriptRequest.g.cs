
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranscriptRequest
    {
        /// <summary>
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Optional intelligence question to evaluate after transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </param>
        /// <param name="filename">
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </param>
        /// <param name="query">
        /// Optional intelligence question to evaluate after transcription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptRequest(
            byte[]? file,
            string? filename,
            string? query)
        {
            this.File = file;
            this.Filename = filename;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptRequest" /> class.
        /// </summary>
        public CreateTranscriptRequest()
        {
        }

    }
}