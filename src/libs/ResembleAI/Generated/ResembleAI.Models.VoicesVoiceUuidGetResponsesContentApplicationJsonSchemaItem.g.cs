
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_language")]
        public string? DefaultLanguage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_type")]
        public string? VoiceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_status")]
        public string? VoiceStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_languages")]
        public global::System.Collections.Generic.IList<string>? SupportedLanguages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_status")]
        public global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus? ComponentStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_support")]
        public global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemApiSupport? ApiSupport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultLanguage"></param>
        /// <param name="voiceType"></param>
        /// <param name="voiceStatus"></param>
        /// <param name="supportedLanguages"></param>
        /// <param name="componentStatus"></param>
        /// <param name="apiSupport"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            string? name,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? defaultLanguage,
            string? voiceType,
            string? voiceStatus,
            global::System.Collections.Generic.IList<string>? supportedLanguages,
            global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus? componentStatus,
            global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemApiSupport? apiSupport,
            string? source)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DefaultLanguage = defaultLanguage;
            this.VoiceType = voiceType;
            this.VoiceStatus = voiceStatus;
            this.SupportedLanguages = supportedLanguages;
            this.ComponentStatus = componentStatus;
            this.ApiSupport = apiSupport;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}