
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults
    {
        /// <summary>
        /// Identified source (e.g., resemble_ai, elevenlabs) or "real" if audio is not synthetic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults" /> class.
        /// </summary>
        /// <param name="label">
        /// Identified source (e.g., resemble_ai, elevenlabs) or "real" if audio is not synthetic
        /// </param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults(
            string? label,
            string? errorMessage)
        {
            this.Label = label;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults" /> class.
        /// </summary>
        public AudioSourceTracingsUuidGetResponsesContentApplicationJsonSchemaItemResults()
        {
        }

    }
}