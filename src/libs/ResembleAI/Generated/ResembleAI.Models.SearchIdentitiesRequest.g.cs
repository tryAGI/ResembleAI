
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchIdentitiesRequest
    {
        /// <summary>
        /// URL to the media sample (one of url, file, signed_id is required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Signed ID from a secure upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_id")]
        public string? SignedId { get; set; }

        /// <summary>
        /// Inferred from the media's content type when omitted (defaults to audio)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter))]
        public global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality? Modality { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIdentitiesRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to the media sample (one of url, file, signed_id is required)
        /// </param>
        /// <param name="signedId">
        /// Signed ID from a secure upload
        /// </param>
        /// <param name="modality">
        /// Inferred from the media's content type when omitted (defaults to audio)
        /// </param>
        /// <param name="topK">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchIdentitiesRequest(
            string? url,
            string? signedId,
            global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality? modality,
            int? topK)
        {
            this.Url = url;
            this.SignedId = signedId;
            this.Modality = modality;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIdentitiesRequest" /> class.
        /// </summary>
        public SearchIdentitiesRequest()
        {
        }

    }
}