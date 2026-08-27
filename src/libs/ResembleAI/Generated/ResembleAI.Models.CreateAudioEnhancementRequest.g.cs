
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAudioEnhancementRequest
    {
        /// <summary>
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioFile { get; set; }

        /// <summary>
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFilename { get; set; }

        /// <summary>
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineJsonConverter))]
        public global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? EnhancementEngine { get; set; }

        /// <summary>
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_noise")]
        public bool? RemoveNoise { get; set; }

        /// <summary>
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_sound")]
        public bool? StudioSound { get; set; }

        /// <summary>
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement_level")]
        public double? EnhancementLevel { get; set; }

        /// <summary>
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_target_level")]
        public int? LoudnessTargetLevel { get; set; }

        /// <summary>
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_peak_limit")]
        public int? LoudnessPeakLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioEnhancementRequest" /> class.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioEnhancementRequest(
            byte[] audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine,
            bool? removeNoise,
            bool? normalize,
            bool? studioSound,
            double? enhancementLevel,
            int? loudnessTargetLevel,
            int? loudnessPeakLimit)
        {
            this.AudioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            this.AudioFilename = audioFilename ?? throw new global::System.ArgumentNullException(nameof(audioFilename));
            this.EnhancementEngine = enhancementEngine;
            this.RemoveNoise = removeNoise;
            this.Normalize = normalize;
            this.StudioSound = studioSound;
            this.EnhancementLevel = enhancementLevel;
            this.LoudnessTargetLevel = loudnessTargetLevel;
            this.LoudnessPeakLimit = loudnessPeakLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioEnhancementRequest" /> class.
        /// </summary>
        public CreateAudioEnhancementRequest()
        {
        }

    }
}