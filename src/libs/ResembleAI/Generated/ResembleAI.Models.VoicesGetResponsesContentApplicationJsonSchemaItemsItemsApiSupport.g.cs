
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync")]
        public bool? Sync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direct_synthesis")]
        public bool? DirectSynthesis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport" /> class.
        /// </summary>
        /// <param name="sync"></param>
        /// <param name="async"></param>
        /// <param name="directSynthesis"></param>
        /// <param name="streaming"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport(
            bool? sync,
            bool? async,
            bool? directSynthesis,
            bool? streaming)
        {
            this.Sync = sync;
            this.Async = async;
            this.DirectSynthesis = directSynthesis;
            this.Streaming = streaming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport" /> class.
        /// </summary>
        public VoicesGetResponsesContentApplicationJsonSchemaItemsItemsApiSupport()
        {
        }

    }
}