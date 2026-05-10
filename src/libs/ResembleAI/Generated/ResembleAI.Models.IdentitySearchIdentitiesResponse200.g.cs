
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentitySearchIdentitiesResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaMatchesItems>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchIdentitiesResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="matches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentitySearchIdentitiesResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaMatchesItems>? matches)
        {
            this.Success = success;
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchIdentitiesResponse200" /> class.
        /// </summary>
        public IdentitySearchIdentitiesResponse200()
        {
        }

    }
}