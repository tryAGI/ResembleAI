
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectWatermarkRequest
    {
        /// <summary>
        /// HTTPS URL to the media file (audio, image, or video).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Custom message used during encoding for image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_message")]
        public string? CustomMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// HTTPS URL to the media file (audio, image, or video).
        /// </param>
        /// <param name="customMessage">
        /// Custom message used during encoding for image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectWatermarkRequest(
            string url,
            string? customMessage)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CustomMessage = customMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectWatermarkRequest" /> class.
        /// </summary>
        public DetectWatermarkRequest()
        {
        }

    }
}