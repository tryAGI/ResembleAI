
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingSubscriptionProduct
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
        /// Product identifier to send as product_slug when updating quantities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_type")]
        public string? UnitType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingSubscriptionProductCategoryJsonConverter))]
        public global::ResembleAI.BillingSubscriptionProductCategory? Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_purchase_quantity")]
        public double? MinPurchaseQuantity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_purchase_quantity")]
        public double? MaxPurchaseQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionProduct" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Product identifier to send as product_slug when updating quantities.
        /// </param>
        /// <param name="unitType"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        /// <param name="minPurchaseQuantity"></param>
        /// <param name="maxPurchaseQuantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingSubscriptionProduct(
            long? id,
            string? name,
            string? slug,
            string? unitType,
            global::ResembleAI.BillingSubscriptionProductCategory? category,
            string? description,
            bool? active,
            double? minPurchaseQuantity,
            double? maxPurchaseQuantity)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.UnitType = unitType;
            this.Category = category;
            this.Description = description;
            this.Active = active;
            this.MinPurchaseQuantity = minPurchaseQuantity;
            this.MaxPurchaseQuantity = maxPurchaseQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionProduct" /> class.
        /// </summary>
        public BillingSubscriptionProduct()
        {
        }

    }
}