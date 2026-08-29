
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// A product and its pricing and quantity rules on a plan.
    /// </summary>
    public sealed partial class BillingPlanProduct
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
        /// Stable product identifier used in product_quantities and changes requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_type")]
        public string? UnitType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingPlanProductCategoryJsonConverter))]
        public global::ResembleAI.BillingPlanProductCategory? Category { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_tiers")]
        public bool? HasTiers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        public global::System.Collections.Generic.IList<global::ResembleAI.BillingProductRateTier>? Tiers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_quantity")]
        public double? IncludedQuantity { get; set; }

        /// <summary>
        /// Whether the plan permits the product quantity to be changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_additional_usage")]
        public bool? AllowAdditionalUsage { get; set; }

        /// <summary>
        /// Minimum allowed quantity for this product on the plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_usage_per_period")]
        public double? MinUsagePerPeriod { get; set; }

        /// <summary>
        /// Maximum allowed quantity for this product on the plan. Null means no plan-specific maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_usage_per_period")]
        public double? MaxUsagePerPeriod { get; set; }

        /// <summary>
        /// Whether the product is displayed in Resemble billing interfaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_visible")]
        public bool? UiVisible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_family")]
        public global::ResembleAI.BillingProductFamily? ProductFamily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanProduct" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Stable product identifier used in product_quantities and changes requests.
        /// </param>
        /// <param name="description"></param>
        /// <param name="unitType"></param>
        /// <param name="category"></param>
        /// <param name="ratePerUnitCents"></param>
        /// <param name="ratePerUnitDollars"></param>
        /// <param name="hasTiers"></param>
        /// <param name="tiers"></param>
        /// <param name="includedQuantity"></param>
        /// <param name="allowAdditionalUsage">
        /// Whether the plan permits the product quantity to be changed.
        /// </param>
        /// <param name="minUsagePerPeriod">
        /// Minimum allowed quantity for this product on the plan.
        /// </param>
        /// <param name="maxUsagePerPeriod">
        /// Maximum allowed quantity for this product on the plan. Null means no plan-specific maximum.
        /// </param>
        /// <param name="uiVisible">
        /// Whether the product is displayed in Resemble billing interfaces.
        /// </param>
        /// <param name="productFamily"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingPlanProduct(
            long? id,
            string? name,
            string? slug,
            string? description,
            string? unitType,
            global::ResembleAI.BillingPlanProductCategory? category,
            int? ratePerUnitCents,
            double? ratePerUnitDollars,
            bool? hasTiers,
            global::System.Collections.Generic.IList<global::ResembleAI.BillingProductRateTier>? tiers,
            double? includedQuantity,
            bool? allowAdditionalUsage,
            double? minUsagePerPeriod,
            double? maxUsagePerPeriod,
            bool? uiVisible,
            global::ResembleAI.BillingProductFamily? productFamily)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
            this.UnitType = unitType;
            this.Category = category;
            this.RatePerUnitCents = ratePerUnitCents;
            this.RatePerUnitDollars = ratePerUnitDollars;
            this.HasTiers = hasTiers;
            this.Tiers = tiers;
            this.IncludedQuantity = includedQuantity;
            this.AllowAdditionalUsage = allowAdditionalUsage;
            this.MinUsagePerPeriod = minUsagePerPeriod;
            this.MaxUsagePerPeriod = maxUsagePerPeriod;
            this.UiVisible = uiVisible;
            this.ProductFamily = productFamily;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanProduct" /> class.
        /// </summary>
        public BillingPlanProduct()
        {
        }

    }
}