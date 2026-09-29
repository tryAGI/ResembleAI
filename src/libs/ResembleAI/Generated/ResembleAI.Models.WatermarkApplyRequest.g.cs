
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkApplyRequest
    {
        /// <summary>
        /// Public HTTPS URL to the audio, image, or video source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// `default` returns WAV (audio), PNG (image), or MP4 (video). `source` returns the source's format (for example JPEG, AVIF, M4A, or MOV) when it can be reproduced, otherwise the default.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.WatermarkApplyRequestOutputFormatJsonConverter))]
        public global::ResembleAI.WatermarkApplyRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Watermark strength for image/video. Ignored for audio.<br/>
        /// Default Value: 0.2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Message to embed in image/video. Ignored for audio.<br/>
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
        /// Initializes a new instance of the <see cref="WatermarkApplyRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Public HTTPS URL to the audio, image, or video source.
        /// </param>
        /// <param name="outputFormat">
        /// `default` returns WAV (audio), PNG (image), or MP4 (video). `source` returns the source's format (for example JPEG, AVIF, M4A, or MOV) when it can be reproduced, otherwise the default.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="strength">
        /// Watermark strength for image/video. Ignored for audio.<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="customMessage">
        /// Message to embed in image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkApplyRequest(
            string url,
            global::ResembleAI.WatermarkApplyRequestOutputFormat? outputFormat,
            double? strength,
            string? customMessage)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.OutputFormat = outputFormat;
            this.Strength = strength;
            this.CustomMessage = customMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyRequest" /> class.
        /// </summary>
        public WatermarkApplyRequest()
        {
        }

    }
}