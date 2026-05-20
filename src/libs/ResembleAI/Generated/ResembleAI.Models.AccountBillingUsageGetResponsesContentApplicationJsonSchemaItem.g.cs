
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect")]
        public double? Detect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synth")]
        public string? Synth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="detect"></param>
        /// <param name="synth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem(
            double? detect,
            string? synth)
        {
            this.Detect = detect;
            this.Synth = synth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public AccountBillingUsageGetResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}