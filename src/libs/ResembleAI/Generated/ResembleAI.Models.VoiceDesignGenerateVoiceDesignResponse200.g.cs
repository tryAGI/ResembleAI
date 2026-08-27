
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceDesignGenerateVoiceDesignResponse200
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_candidates")]
        public global::System.Collections.Generic.IList<global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems>? VoiceCandidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignGenerateVoiceDesignResponse200" /> class.
        /// </summary>
        /// <param name="voiceCandidates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignGenerateVoiceDesignResponse200(
            global::System.Collections.Generic.IList<global::ResembleAI.VoiceDesignPostResponsesContentApplicationJsonSchemaVoiceCandidatesItems>? voiceCandidates)
        {
            this.VoiceCandidates = voiceCandidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignGenerateVoiceDesignResponse200" /> class.
        /// </summary>
        public VoiceDesignGenerateVoiceDesignResponse200()
        {
        }

    }
}