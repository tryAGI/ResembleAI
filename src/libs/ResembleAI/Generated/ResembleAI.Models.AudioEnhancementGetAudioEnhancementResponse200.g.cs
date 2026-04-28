
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioEnhancementGetAudioEnhancementResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusJsonConverter))]
        public global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus? Status { get; set; }

        /// <summary>
        /// Download URL. Only present when status is completed. This is a temporary signed URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_audio_url")]
        public string? EnhancedAudioUrl { get; set; }

        /// <summary>
        /// Human-readable error. Only present when status is failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementGetAudioEnhancementResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        /// <param name="enhancedAudioUrl">
        /// Download URL. Only present when status is completed. This is a temporary signed URL.
        /// </param>
        /// <param name="errorMessage">
        /// Human-readable error. Only present when status is failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEnhancementGetAudioEnhancementResponse200(
            bool? success,
            string? uuid,
            global::ResembleAI.AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus? status,
            string? enhancedAudioUrl,
            string? errorMessage)
        {
            this.Success = success;
            this.Uuid = uuid;
            this.Status = status;
            this.EnhancedAudioUrl = enhancedAudioUrl;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementGetAudioEnhancementResponse200" /> class.
        /// </summary>
        public AudioEnhancementGetAudioEnhancementResponse200()
        {
        }
    }
}