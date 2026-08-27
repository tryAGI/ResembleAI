
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingPlan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Stable plan identifier used when creating or changing a subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingPlanPlanTypeJsonConverter))]
        public global::ResembleAI.BillingPlanPlanType? PlanType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_fee_cents")]
        public int? BaseFeeCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_fee_dollars")]
        public double? BaseFeeDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_base_cost_cents")]
        public int? TotalBaseCostCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_base_cost_dollars")]
        public double? TotalBaseCostDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_dollar_balance_cents")]
        public int? IncludedDollarBalanceCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_dollar_balance_dollars")]
        public double? IncludedDollarBalanceDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingPlanBillingIntervalJsonConverter))]
        public global::ResembleAI.BillingPlanBillingInterval? BillingInterval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_family")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingPlanFamily, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.BillingPlanFamily, object>? PlanFamily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::ResembleAI.BillingPlanProduct>? Products { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlan" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Stable plan identifier used when creating or changing a subscription.
        /// </param>
        /// <param name="planType"></param>
        /// <param name="baseFeeCents"></param>
        /// <param name="baseFeeDollars"></param>
        /// <param name="totalBaseCostCents"></param>
        /// <param name="totalBaseCostDollars"></param>
        /// <param name="includedDollarBalanceCents"></param>
        /// <param name="includedDollarBalanceDollars"></param>
        /// <param name="billingInterval"></param>
        /// <param name="planFamily"></param>
        /// <param name="active"></param>
        /// <param name="products"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingPlan(
            long? id,
            string? name,
            string? slug,
            global::ResembleAI.BillingPlanPlanType? planType,
            int? baseFeeCents,
            double? baseFeeDollars,
            int? totalBaseCostCents,
            double? totalBaseCostDollars,
            int? includedDollarBalanceCents,
            double? includedDollarBalanceDollars,
            global::ResembleAI.BillingPlanBillingInterval? billingInterval,
            global::ResembleAI.OneOf<global::ResembleAI.BillingPlanFamily, object>? planFamily,
            bool? active,
            global::System.Collections.Generic.IList<global::ResembleAI.BillingPlanProduct>? products,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.PlanType = planType;
            this.BaseFeeCents = baseFeeCents;
            this.BaseFeeDollars = baseFeeDollars;
            this.TotalBaseCostCents = totalBaseCostCents;
            this.TotalBaseCostDollars = totalBaseCostDollars;
            this.IncludedDollarBalanceCents = includedDollarBalanceCents;
            this.IncludedDollarBalanceDollars = includedDollarBalanceDollars;
            this.BillingInterval = billingInterval;
            this.PlanFamily = planFamily;
            this.Active = active;
            this.Products = products;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlan" /> class.
        /// </summary>
        public BillingPlan()
        {
        }

    }
}