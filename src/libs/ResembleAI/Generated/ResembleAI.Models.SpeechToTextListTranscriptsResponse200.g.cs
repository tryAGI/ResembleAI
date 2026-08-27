
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextListTranscriptsResponse200
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>? Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextListTranscriptsResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextListTranscriptsResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaItemsItems>? items,
            global::ResembleAI.SpeechToTextGetResponsesContentApplicationJsonSchemaMeta? meta)
        {
            this.Success = success;
            this.Items = items;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextListTranscriptsResponse200" /> class.
        /// </summary>
        public SpeechToTextListTranscriptsResponse200()
        {
        }

    }
}