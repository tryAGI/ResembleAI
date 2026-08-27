
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityEmbeddingsItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter))]
        public global::ResembleAI.IdentityEmbeddingsItemsModality? Modality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_count")]
        public int? AttachmentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computed_at")]
        public global::System.DateTime? ComputedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEmbeddingsItems" /> class.
        /// </summary>
        /// <param name="modality"></param>
        /// <param name="status"></param>
        /// <param name="attachmentCount"></param>
        /// <param name="computedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityEmbeddingsItems(
            global::ResembleAI.IdentityEmbeddingsItemsModality? modality,
            string? status,
            int? attachmentCount,
            global::System.DateTime? computedAt)
        {
            this.Modality = modality;
            this.Status = status;
            this.AttachmentCount = attachmentCount;
            this.ComputedAt = computedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityEmbeddingsItems" /> class.
        /// </summary>
        public IdentityEmbeddingsItems()
        {
        }

    }
}