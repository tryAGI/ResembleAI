
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Structured intelligence analysis
    /// </summary>
    public sealed partial class IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_info")]
        public string? SpeakerInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialect")]
        public string? Dialect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_style")]
        public string? SpeakingStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abnormalities")]
        public string? Abnormalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public string? Translation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misinformation")]
        public string? Misinformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fraud")]
        public global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraud? Fraud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liveness")]
        public global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLiveness? Liveness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digitally_altered")]
        public global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionDigitallyAltered? DigitallyAltered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription" /> class.
        /// </summary>
        /// <param name="speakerInfo"></param>
        /// <param name="language"></param>
        /// <param name="dialect"></param>
        /// <param name="emotion"></param>
        /// <param name="speakingStyle"></param>
        /// <param name="context"></param>
        /// <param name="message"></param>
        /// <param name="abnormalities"></param>
        /// <param name="transcription"></param>
        /// <param name="translation"></param>
        /// <param name="misinformation"></param>
        /// <param name="fraud"></param>
        /// <param name="liveness"></param>
        /// <param name="digitallyAltered"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription(
            string? speakerInfo,
            string? language,
            string? dialect,
            string? emotion,
            string? speakingStyle,
            string? context,
            string? message,
            string? abnormalities,
            string? transcription,
            string? translation,
            string? misinformation,
            global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraud? fraud,
            global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLiveness? liveness,
            global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionDigitallyAltered? digitallyAltered)
        {
            this.SpeakerInfo = speakerInfo;
            this.Language = language;
            this.Dialect = dialect;
            this.Emotion = emotion;
            this.SpeakingStyle = speakingStyle;
            this.Context = context;
            this.Message = message;
            this.Abnormalities = abnormalities;
            this.Transcription = transcription;
            this.Translation = translation;
            this.Misinformation = misinformation;
            this.Fraud = fraud;
            this.Liveness = liveness;
            this.DigitallyAltered = digitallyAltered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription" /> class.
        /// </summary>
        public IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription()
        {
        }

    }
}