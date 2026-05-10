
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAudioEditRequest
    {
        /// <summary>
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] InputAudio { get; set; }

        /// <summary>
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputAudioname { get; set; }

        /// <summary>
        /// Accurate transcript of the uploaded audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalTranscript { get; set; }

        /// <summary>
        /// Desired replacement text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetTranscript { get; set; }

        /// <summary>
        /// Voice used to render the edited segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioEditRequest" /> class.
        /// </summary>
        /// <param name="inputAudio">
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </param>
        /// <param name="inputAudioname">
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </param>
        /// <param name="originalTranscript">
        /// Accurate transcript of the uploaded audio
        /// </param>
        /// <param name="targetTranscript">
        /// Desired replacement text
        /// </param>
        /// <param name="voiceUuid">
        /// Voice used to render the edited segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioEditRequest(
            byte[] inputAudio,
            string inputAudioname,
            string originalTranscript,
            string targetTranscript,
            string voiceUuid)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.InputAudioname = inputAudioname ?? throw new global::System.ArgumentNullException(nameof(inputAudioname));
            this.OriginalTranscript = originalTranscript ?? throw new global::System.ArgumentNullException(nameof(originalTranscript));
            this.TargetTranscript = targetTranscript ?? throw new global::System.ArgumentNullException(nameof(targetTranscript));
            this.VoiceUuid = voiceUuid ?? throw new global::System.ArgumentNullException(nameof(voiceUuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioEditRequest" /> class.
        /// </summary>
        public CreateAudioEditRequest()
        {
        }

    }
}