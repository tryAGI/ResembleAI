
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Structured intelligence analysis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UUID of the associated detect object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_uuid")]
        public string? DetectUuid { get; set; }

        /// <summary>
        /// Type of media analyzed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter))]
        public global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType? MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="description">
        /// Structured intelligence analysis
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="detectUuid">
        /// UUID of the associated detect object
        /// </param>
        /// <param name="mediaType">
        /// Type of media analyzed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems(
            string? uuid,
            global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription? description,
            global::System.DateTime? createdAt,
            string? detectUuid,
            global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType? mediaType)
        {
            this.Uuid = uuid;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.DetectUuid = detectUuid;
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems()
        {
        }

    }
}