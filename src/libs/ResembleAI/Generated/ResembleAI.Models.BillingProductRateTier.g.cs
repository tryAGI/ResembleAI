
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingProductRateTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_order")]
        public int? TierOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_quantity")]
        public double? MinQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_quantity")]
        public double? MaxQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_unit_cents")]
        public int? RatePerUnitCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_unit_dollars")]
        public double? RatePerUnitDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingProductRateTier" /> class.
        /// </summary>
        /// <param name="tierOrder"></param>
        /// <param name="minQuantity"></param>
        /// <param name="maxQuantity"></param>
        /// <param name="ratePerUnitCents"></param>
        /// <param name="ratePerUnitDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingProductRateTier(
            int? tierOrder,
            double? minQuantity,
            double? maxQuantity,
            int? ratePerUnitCents,
            double? ratePerUnitDollars)
        {
            this.TierOrder = tierOrder;
            this.MinQuantity = minQuantity;
            this.MaxQuantity = maxQuantity;
            this.RatePerUnitCents = ratePerUnitCents;
            this.RatePerUnitDollars = ratePerUnitDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingProductRateTier" /> class.
        /// </summary>
        public BillingProductRateTier()
        {
        }

    }
}