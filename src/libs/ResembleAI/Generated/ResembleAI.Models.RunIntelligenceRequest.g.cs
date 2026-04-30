
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunIntelligenceRequest
    {
        /// <summary>
        /// Token for uploaded media file (from secure upload)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_token")]
        public string? MediaToken { get; set; }

        /// <summary>
        /// HTTPS URL to audio, image, or video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// UUID of an existing detect to associate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_id")]
        public global::System.Guid? DetectId { get; set; }

        /// <summary>
        /// Explicit media type (auto-detected if not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter))]
        public global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType? MediaType { get; set; }

        /// <summary>
        /// URL that receives the final intelligence payload via HTTP POST. When present, the request runs asynchronously and returns 202 Accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunIntelligenceRequest" /> class.
        /// </summary>
        /// <param name="mediaToken">
        /// Token for uploaded media file (from secure upload)
        /// </param>
        /// <param name="url">
        /// HTTPS URL to audio, image, or video file
        /// </param>
        /// <param name="detectId">
        /// UUID of an existing detect to associate
        /// </param>
        /// <param name="mediaType">
        /// Explicit media type (auto-detected if not provided)
        /// </param>
        /// <param name="callbackUrl">
        /// URL that receives the final intelligence payload via HTTP POST. When present, the request runs asynchronously and returns 202 Accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunIntelligenceRequest(
            string? mediaToken,
            string? url,
            global::System.Guid? detectId,
            global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType? mediaType,
            string? callbackUrl)
        {
            this.MediaToken = mediaToken;
            this.Url = url;
            this.DetectId = detectId;
            this.MediaType = mediaType;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunIntelligenceRequest" /> class.
        /// </summary>
        public RunIntelligenceRequest()
        {
        }
    }
}