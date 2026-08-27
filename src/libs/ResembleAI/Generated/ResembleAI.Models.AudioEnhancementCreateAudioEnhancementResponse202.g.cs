
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioEnhancementCreateAudioEnhancementResponse202
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusJsonConverter))]
        public global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementCreateAudioEnhancementResponse202" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEnhancementCreateAudioEnhancementResponse202(
            bool? success,
            string? uuid,
            global::ResembleAI.AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus? status)
        {
            this.Success = success;
            this.Uuid = uuid;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementCreateAudioEnhancementResponse202" /> class.
        /// </summary>
        public AudioEnhancementCreateAudioEnhancementResponse202()
        {
        }

    }
}