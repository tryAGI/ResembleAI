
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
        /// Public HTTPS URL that receives a POST with the result when processing finishes. Private, loopback, link-local, and non-HTTPS URLs are rejected. Required when zero_retention_mode is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Enable zero retention. The uploaded media and any temporary processing copies are permanently deleted after transcription, and the transcript content is purged after one delivery to callback_url (which is mandatory in this mode). privacy_mode is accepted as an alias. Plan feature — requests are rejected with 402 if not included in your plan.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_retention_mode")]
        public bool? ZeroRetentionMode { get; set; }

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
        /// <param name="callbackUrl">
        /// Public HTTPS URL that receives a POST with the result when processing finishes. Private, loopback, link-local, and non-HTTPS URLs are rejected. Required when zero_retention_mode is true.
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable zero retention. The uploaded media and any temporary processing copies are permanently deleted after transcription, and the transcript content is purged after one delivery to callback_url (which is mandatory in this mode). privacy_mode is accepted as an alias. Plan feature — requests are rejected with 402 if not included in your plan.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptRequest(
            byte[]? file,
            string? filename,
            string? query,
            string? callbackUrl,
            bool? zeroRetentionMode)
        {
            this.File = file;
            this.Filename = filename;
            this.Query = query;
            this.CallbackUrl = callbackUrl;
            this.ZeroRetentionMode = zeroRetentionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptRequest" /> class.
        /// </summary>
        public CreateTranscriptRequest()
        {
        }

    }
}