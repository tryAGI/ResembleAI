
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
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineJsonConverter))]
        public global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine? EnhancementEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Engine v2 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_noise")]
        public bool? RemoveNoise { get; set; }

        /// <summary>
        /// Engine v2 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// Engine v2 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_sound")]
        public bool? StudioSound { get; set; }

        /// <summary>
        /// Engine v1 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_target_level")]
        public int? LoudnessTargetLevel { get; set; }

        /// <summary>
        /// Engine v1 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_peak_limit")]
        public int? LoudnessPeakLimit { get; set; }

        /// <summary>
        /// Engine v1 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement_level")]
        public double? EnhancementLevel { get; set; }

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
        /// <param name="enhancementEngine"></param>
        /// <param name="errorMessage"></param>
        /// <param name="removeNoise">
        /// Engine v2 only.
        /// </param>
        /// <param name="normalize">
        /// Engine v2 only.
        /// </param>
        /// <param name="studioSound">
        /// Engine v2 only.
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Engine v1 only.
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Engine v1 only.
        /// </param>
        /// <param name="enhancementLevel">
        /// Engine v1 only.
        /// </param>
        /// <param name="originalAudioUrl"></param>
        /// <param name="enhancedAudioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItems(
            string? uuid,
            global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? status,
            global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine? enhancementEngine,
            string? errorMessage,
            bool? removeNoise,
            bool? normalize,
            bool? studioSound,
            int? loudnessTargetLevel,
            int? loudnessPeakLimit,
            double? enhancementLevel,
            string? originalAudioUrl,
            string? enhancedAudioUrl)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.EnhancementEngine = enhancementEngine;
            this.ErrorMessage = errorMessage;
            this.RemoveNoise = removeNoise;
            this.Normalize = normalize;
            this.StudioSound = studioSound;
            this.LoudnessTargetLevel = loudnessTargetLevel;
            this.LoudnessPeakLimit = loudnessPeakLimit;
            this.EnhancementLevel = enhancementLevel;
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