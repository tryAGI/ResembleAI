
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_to_speech")]
        public global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech? TextToSpeech { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusFill? Fill { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_conversion")]
        public global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion? VoiceConversion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus" /> class.
        /// </summary>
        /// <param name="textToSpeech"></param>
        /// <param name="fill"></param>
        /// <param name="voiceConversion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus(
            global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusTextToSpeech? textToSpeech,
            global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusFill? fill,
            global::ResembleAI.VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatusVoiceConversion? voiceConversion)
        {
            this.TextToSpeech = textToSpeech;
            this.Fill = fill;
            this.VoiceConversion = voiceConversion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus" /> class.
        /// </summary>
        public VoicesPostResponsesContentApplicationJsonSchemaItemComponentStatus()
        {
        }

    }
}