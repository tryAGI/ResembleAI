
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Intelligence results when requested
    /// </summary>
    public sealed partial class DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter))]
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence(
            string? uuid,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription? description,
            global::System.DateTime? createdAt)
        {
            this.Uuid = uuid;
            this.Description = description;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence" /> class.
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence()
        {
        }
    }
}