
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
        /// Remove background noise.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_noise")]
        public bool? RemoveNoise { get; set; }

        /// <summary>
        /// Normalize audio levels.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// Apply studio-quality enhancement.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_sound")]
        public bool? StudioSound { get; set; }

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
        /// <param name="removeNoise">
        /// Remove background noise.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioEnhancementRequest(
            byte[] audioFile,
            string audioFilename,
            bool? removeNoise,
            bool? normalize,
            bool? studioSound)
        {
            this.AudioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            this.AudioFilename = audioFilename ?? throw new global::System.ArgumentNullException(nameof(audioFilename));
            this.RemoveNoise = removeNoise;
            this.Normalize = normalize;
            this.StudioSound = studioSound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioEnhancementRequest" /> class.
        /// </summary>
        public CreateAudioEnhancementRequest()
        {
        }

    }
}