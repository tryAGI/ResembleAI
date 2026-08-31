
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusJsonConverter))]
        public global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Whether background noise removal was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_noise")]
        public bool? RemoveNoise { get; set; }

        /// <summary>
        /// Whether loudness normalization was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// Whether studio-quality enhancement was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_sound")]
        public bool? StudioSound { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_audio_url")]
        public string? OriginalAudioUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_audio_url")]
        public string? EnhancedAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
        /// <param name="errorMessage"></param>
        /// <param name="removeNoise">
        /// Whether background noise removal was applied.
        /// </param>
        /// <param name="normalize">
        /// Whether loudness normalization was applied.
        /// </param>
        /// <param name="studioSound">
        /// Whether studio-quality enhancement was applied.
        /// </param>
        /// <param name="originalAudioUrl"></param>
        /// <param name="enhancedAudioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems(
            string? uuid,
            global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? status,
            string? errorMessage,
            bool? removeNoise,
            bool? normalize,
            bool? studioSound,
            string? originalAudioUrl,
            string? enhancedAudioUrl)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.RemoveNoise = removeNoise;
            this.Normalize = normalize;
            this.StudioSound = studioSound;
            this.OriginalAudioUrl = originalAudioUrl;
            this.EnhancedAudioUrl = enhancedAudioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems()
        {
        }

    }
}