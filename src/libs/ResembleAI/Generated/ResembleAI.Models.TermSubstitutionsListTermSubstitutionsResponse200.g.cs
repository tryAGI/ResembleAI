
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TermSubstitutionsListTermSubstitutionsResponse200
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
        public global::System.Collections.Generic.IList<global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TermSubstitutionsListTermSubstitutionsResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TermSubstitutionsListTermSubstitutionsResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.TermSubstitutionsGetResponsesContentApplicationJsonSchemaItemsItems>? items)
        {
            this.Success = success;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermSubstitutionsListTermSubstitutionsResponse200" /> class.
        /// </summary>
        public TermSubstitutionsListTermSubstitutionsResponse200()
        {
        }
    }
}