
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: professional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceTypeJsonConverter))]
        public global::ResembleAI.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType? VoiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_url")]
        public string? DatasetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_uri")]
        public string? CallbackUri { get; set; }

        /// <summary>
        /// Default Value: en-US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="voiceType">
        /// Default Value: professional
        /// </param>
        /// <param name="datasetUrl"></param>
        /// <param name="callbackUri"></param>
        /// <param name="language">
        /// Default Value: en-US
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceRequest(
            string name,
            global::ResembleAI.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType? voiceType,
            string? datasetUrl,
            string? callbackUri,
            string? language)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VoiceType = voiceType;
            this.DatasetUrl = datasetUrl;
            this.CallbackUri = callbackUri;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        public CreateVoiceRequest()
        {
        }

    }
}