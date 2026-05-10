
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomPronunciationsBulkCreatePronunciationsResponse201
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Number of pronunciations successfully created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_created")]
        public int? TotalCreated { get; set; }

        /// <summary>
        /// Number of files that failed validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_errors")]
        public int? TotalErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.CustomPronunciation>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPronunciationsBulkCreatePronunciationsResponse201" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="totalCreated">
        /// Number of pronunciations successfully created
        /// </param>
        /// <param name="totalErrors">
        /// Number of files that failed validation
        /// </param>
        /// <param name="items"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomPronunciationsBulkCreatePronunciationsResponse201(
            bool? success,
            int? totalCreated,
            int? totalErrors,
            global::System.Collections.Generic.IList<global::ResembleAI.CustomPronunciation>? items,
            global::System.Collections.Generic.IList<global::ResembleAI.PronunciationsBulkPostResponsesContentApplicationJsonSchemaErrorsItems>? errors)
        {
            this.Success = success;
            this.TotalCreated = totalCreated;
            this.TotalErrors = totalErrors;
            this.Items = items;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPronunciationsBulkCreatePronunciationsResponse201" /> class.
        /// </summary>
        public CustomPronunciationsBulkCreatePronunciationsResponse201()
        {
        }

    }
}