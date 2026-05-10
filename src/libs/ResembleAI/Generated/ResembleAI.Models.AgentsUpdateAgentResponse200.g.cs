
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsUpdateAgentResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::ResembleAI.AgentsUuidPatchResponsesContentApplicationJsonSchemaItem? Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="item"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsUpdateAgentResponse200(
            bool? success,
            global::ResembleAI.AgentsUuidPatchResponsesContentApplicationJsonSchemaItem? item,
            string? message)
        {
            this.Success = success;
            this.Item = item;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsUpdateAgentResponse200" /> class.
        /// </summary>
        public AgentsUpdateAgentResponse200()
        {
        }

    }
}