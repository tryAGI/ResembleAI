
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingProductQuantityChange
    {
        /// <summary>
        /// Product slug returned by the subscription response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductSlug { get; set; }

        /// <summary>
        /// Desired absolute total, not an increment or decrement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NewQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingProductQuantityChange" /> class.
        /// </summary>
        /// <param name="productSlug">
        /// Product slug returned by the subscription response.
        /// </param>
        /// <param name="newQuantity">
        /// Desired absolute total, not an increment or decrement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingProductQuantityChange(
            string productSlug,
            double newQuantity)
        {
            this.ProductSlug = productSlug ?? throw new global::System.ArgumentNullException(nameof(productSlug));
            this.NewQuantity = newQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingProductQuantityChange" /> class.
        /// </summary>
        public BillingProductQuantityChange()
        {
        }

    }
}