
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public double? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="speakerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems(
            string? text,
            double? startTime,
            double? endTime,
            string? speakerId)
        {
            this.Text = text;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.SpeakerId = speakerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems" /> class.
        /// </summary>
        public SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemWordsItems()
        {
        }

    }
}