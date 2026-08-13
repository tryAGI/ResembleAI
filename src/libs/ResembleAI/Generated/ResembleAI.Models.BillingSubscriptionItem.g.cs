
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingSubscriptionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Current absolute quantity on the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Quantity currently in use. A product cannot be reduced below this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumed_quantity")]
        public double? ConsumedQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public global::ResembleAI.BillingSubscriptionProduct? Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_product")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscriptionPlanProduct, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.BillingSubscriptionPlanProduct, object>? PlanProduct { get; set; }

        /// <summary>
        /// Locked-in unit rate for this subscription item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_unit_cents")]
        public double? RatePerUnitCents { get; set; }

        /// <summary>
        /// Current catalog unit rate for comparison.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_rate_per_unit_cents")]
        public double? CurrentRatePerUnitCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_grandfathered")]
        public bool? IsGrandfathered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_locked_at")]
        public global::System.DateTime? RateLockedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_visible")]
        public bool? UiVisible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity">
        /// Current absolute quantity on the subscription.
        /// </param>
        /// <param name="consumedQuantity">
        /// Quantity currently in use. A product cannot be reduced below this value.
        /// </param>
        /// <param name="product"></param>
        /// <param name="planProduct"></param>
        /// <param name="ratePerUnitCents">
        /// Locked-in unit rate for this subscription item.
        /// </param>
        /// <param name="currentRatePerUnitCents">
        /// Current catalog unit rate for comparison.
        /// </param>
        /// <param name="isGrandfathered"></param>
        /// <param name="rateLockedAt"></param>
        /// <param name="uiVisible"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingSubscriptionItem(
            long? id,
            double? quantity,
            double? consumedQuantity,
            global::ResembleAI.BillingSubscriptionProduct? product,
            global::ResembleAI.OneOf<global::ResembleAI.BillingSubscriptionPlanProduct, object>? planProduct,
            double? ratePerUnitCents,
            double? currentRatePerUnitCents,
            bool? isGrandfathered,
            global::System.DateTime? rateLockedAt,
            bool? uiVisible)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.ConsumedQuantity = consumedQuantity;
            this.Product = product;
            this.PlanProduct = planProduct;
            this.RatePerUnitCents = ratePerUnitCents;
            this.CurrentRatePerUnitCents = currentRatePerUnitCents;
            this.IsGrandfathered = isGrandfathered;
            this.RateLockedAt = rateLockedAt;
            this.UiVisible = uiVisible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionItem" /> class.
        /// </summary>
        public BillingSubscriptionItem()
        {
        }

    }
}