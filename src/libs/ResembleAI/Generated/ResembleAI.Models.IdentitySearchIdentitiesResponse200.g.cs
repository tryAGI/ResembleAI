
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
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter))]
        public global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality? Modality { get; set; }

        /// <summary>
        /// Matches keyed by identity UUID. distance is a 0-100 match score (higher is closer; an identical sample scores 100). Image matches include score_type "cosine".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::System.Collections.Generic.Dictionary<string, global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem>? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchIdentitiesResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="modality"></param>
        /// <param name="item">
        /// Matches keyed by identity UUID. distance is a 0-100 match score (higher is closer; an identical sample scores 100). Image matches include score_type "cosine".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentitySearchIdentitiesResponse200(
            bool? success,
            global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality? modality,
            global::System.Collections.Generic.Dictionary<string, global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem>? item)
        {
            this.Success = success;
            this.Modality = modality;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchIdentitiesResponse200" /> class.
        /// </summary>
        public IdentitySearchIdentitiesResponse200()
        {
        }

    }
}