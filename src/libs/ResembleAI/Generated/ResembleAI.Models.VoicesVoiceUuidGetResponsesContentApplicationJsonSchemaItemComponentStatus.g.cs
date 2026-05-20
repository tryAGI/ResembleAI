
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_to_speech")]
        public global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech? TextToSpeech { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusFill? Fill { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_conversion")]
        public global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion? VoiceConversion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus" /> class.
        /// </summary>
        /// <param name="textToSpeech"></param>
        /// <param name="fill"></param>
        /// <param name="voiceConversion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus(
            global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech? textToSpeech,
            global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusFill? fill,
            global::ResembleAI.VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion? voiceConversion)
        {
            this.TextToSpeech = textToSpeech;
            this.Fill = fill;
            this.VoiceConversion = voiceConversion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus" /> class.
        /// </summary>
        public VoicesVoiceUuidGetResponsesContentApplicationJsonSchemaItemComponentStatus()
        {
        }

    }
}