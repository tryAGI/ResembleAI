
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsListAgentsResponse200
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
        public global::System.Collections.Generic.IList<global::ResembleAI.AgentsGetResponsesContentApplicationJsonSchemaItemsItems>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsListAgentsResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsListAgentsResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.AgentsGetResponsesContentApplicationJsonSchemaItemsItems>? items,
            int? count)
        {
            this.Success = success;
            this.Items = items;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsListAgentsResponse200" /> class.
        /// </summary>
        public AgentsListAgentsResponse200()
        {
        }
    }
}