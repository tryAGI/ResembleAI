
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountGetBillingUsageResponse200
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
        public global::ResembleAI.AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetBillingUsageResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetBillingUsageResponse200(
            bool? success,
            global::ResembleAI.AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem? items)
        {
            this.Success = success;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetBillingUsageResponse200" /> class.
        /// </summary>
        public AccountGetBillingUsageResponse200()
        {
        }

    }
}