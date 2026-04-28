
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItemsResults? Results { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="results"></param>
        /// <param name="createdAt"></param>
        /// <param name="detectUuid">
        /// UUID of the associated detect object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems(
            string? uuid,
            global::ResembleAI.AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItemsResults? results,
            global::System.DateTime? createdAt,
            string? detectUuid)
        {
            this.Uuid = uuid;
            this.Results = results;
            this.CreatedAt = createdAt;
            this.DetectUuid = detectUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public AudioSourceTracingsGetResponsesContentApplicationJsonSchemaItemsItems()
        {
        }
    }
}