
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingPlansResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.BillingPlan> Plans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlansResponse" /> class.
        /// </summary>
        /// <param name="plans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingPlansResponse(
            global::System.Collections.Generic.IList<global::ResembleAI.BillingPlan> plans)
        {
            this.Plans = plans ?? throw new global::System.ArgumentNullException(nameof(plans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlansResponse" /> class.
        /// </summary>
        public BillingPlansResponse()
        {
        }

    }
}