
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingChangePlanRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanSlug { get; set; }

        /// <summary>
        /// Optional map of product slugs to desired quantities on the new plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_quantities")]
        public global::System.Collections.Generic.Dictionary<string, double>? ProductQuantities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingChangePlanRequest" /> class.
        /// </summary>
        /// <param name="planSlug"></param>
        /// <param name="productQuantities">
        /// Optional map of product slugs to desired quantities on the new plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingChangePlanRequest(
            string planSlug,
            global::System.Collections.Generic.Dictionary<string, double>? productQuantities)
        {
            this.PlanSlug = planSlug ?? throw new global::System.ArgumentNullException(nameof(planSlug));
            this.ProductQuantities = productQuantities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingChangePlanRequest" /> class.
        /// </summary>
        public BillingChangePlanRequest()
        {
        }

    }
}