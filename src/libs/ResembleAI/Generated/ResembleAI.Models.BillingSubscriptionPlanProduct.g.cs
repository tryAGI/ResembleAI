
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Quantity rules inherited from the subscription's current plan.
    /// </summary>
    public sealed partial class BillingSubscriptionPlanProduct
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_quantity")]
        public double? IncludedQuantity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_additional_usage")]
        public bool? AllowAdditionalUsage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_usage_per_period")]
        public double? MinUsagePerPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_usage_per_period")]
        public double? MaxUsagePerPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionPlanProduct" /> class.
        /// </summary>
        /// <param name="includedQuantity"></param>
        /// <param name="allowAdditionalUsage"></param>
        /// <param name="minUsagePerPeriod"></param>
        /// <param name="maxUsagePerPeriod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingSubscriptionPlanProduct(
            double? includedQuantity,
            bool? allowAdditionalUsage,
            double? minUsagePerPeriod,
            double? maxUsagePerPeriod)
        {
            this.IncludedQuantity = includedQuantity;
            this.AllowAdditionalUsage = allowAdditionalUsage;
            this.MinUsagePerPeriod = minUsagePerPeriod;
            this.MaxUsagePerPeriod = maxUsagePerPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionPlanProduct" /> class.
        /// </summary>
        public BillingSubscriptionPlanProduct()
        {
        }

    }
}