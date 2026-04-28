
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DispatchAgentRequest
    {
        /// <summary>
        /// Destination phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Runtime variable overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::ResembleAI.AgentsUuidDispatchPostRequestBodyContentApplicationJsonSchemaDynamicVariables? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DispatchAgentRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Destination phone number
        /// </param>
        /// <param name="dynamicVariables">
        /// Runtime variable overrides
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DispatchAgentRequest(
            string phoneNumber,
            global::ResembleAI.AgentsUuidDispatchPostRequestBodyContentApplicationJsonSchemaDynamicVariables? dynamicVariables)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DispatchAgentRequest" /> class.
        /// </summary>
        public DispatchAgentRequest()
        {
        }
    }
}