
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_sample_index")]
        public int? VoiceSampleIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="voiceSampleIndex"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems(
            string? audioUrl,
            int? voiceSampleIndex,
            string? uuid)
        {
            this.AudioUrl = audioUrl;
            this.VoiceSampleIndex = voiceSampleIndex;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems" /> class.
        /// </summary>
        public VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems()
        {
        }

    }
}