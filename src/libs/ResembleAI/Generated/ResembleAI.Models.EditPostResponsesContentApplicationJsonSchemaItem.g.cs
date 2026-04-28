
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditPostResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        public string? VoiceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_transcript")]
        public string? OriginalTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_transcript")]
        public string? TargetTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_url")]
        public string? InputAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="voiceUuid"></param>
        /// <param name="originalTranscript"></param>
        /// <param name="targetTranscript"></param>
        /// <param name="inputAudioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditPostResponsesContentApplicationJsonSchemaItem(
            string? uuid,
            string? voiceUuid,
            string? originalTranscript,
            string? targetTranscript,
            string? inputAudioUrl)
        {
            this.Uuid = uuid;
            this.VoiceUuid = voiceUuid;
            this.OriginalTranscript = originalTranscript;
            this.TargetTranscript = targetTranscript;
            this.InputAudioUrl = inputAudioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public EditPostResponsesContentApplicationJsonSchemaItem()
        {
        }
    }
}