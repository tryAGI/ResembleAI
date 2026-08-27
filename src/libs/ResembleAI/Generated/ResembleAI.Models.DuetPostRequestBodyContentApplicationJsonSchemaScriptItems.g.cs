
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DuetPostRequestBodyContentApplicationJsonSchemaScriptItems
    {
        /// <summary>
        /// Speaker index (0 or 1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker Speaker { get; set; }

        /// <summary>
        /// Text for this speaker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuetPostRequestBodyContentApplicationJsonSchemaScriptItems" /> class.
        /// </summary>
        /// <param name="speaker">
        /// Speaker index (0 or 1)
        /// </param>
        /// <param name="text">
        /// Text for this speaker
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuetPostRequestBodyContentApplicationJsonSchemaScriptItems(
            global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker speaker,
            string text)
        {
            this.Speaker = speaker;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuetPostRequestBodyContentApplicationJsonSchemaScriptItems" /> class.
        /// </summary>
        public DuetPostRequestBodyContentApplicationJsonSchemaScriptItems()
        {
        }

    }
}