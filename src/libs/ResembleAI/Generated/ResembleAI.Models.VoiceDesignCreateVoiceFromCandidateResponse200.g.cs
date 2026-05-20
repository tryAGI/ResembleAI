
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceDesignCreateVoiceFromCandidateResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        public string? VoiceUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignCreateVoiceFromCandidateResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="voiceUuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceDesignCreateVoiceFromCandidateResponse200(
            bool? success,
            string? voiceUuid)
        {
            this.Success = success;
            this.VoiceUuid = voiceUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceDesignCreateVoiceFromCandidateResponse200" /> class.
        /// </summary>
        public VoiceDesignCreateVoiceFromCandidateResponse200()
        {
        }

    }
}