
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTermSubstitutionRequest
    {
        /// <summary>
        /// Original text to substitute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalText { get; set; }

        /// <summary>
        /// Replacement pronunciation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacement_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplacementText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTermSubstitutionRequest" /> class.
        /// </summary>
        /// <param name="originalText">
        /// Original text to substitute
        /// </param>
        /// <param name="replacementText">
        /// Replacement pronunciation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTermSubstitutionRequest(
            string originalText,
            string replacementText)
        {
            this.OriginalText = originalText ?? throw new global::System.ArgumentNullException(nameof(originalText));
            this.ReplacementText = replacementText ?? throw new global::System.ArgumentNullException(nameof(replacementText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTermSubstitutionRequest" /> class.
        /// </summary>
        public CreateTermSubstitutionRequest()
        {
        }
    }
}