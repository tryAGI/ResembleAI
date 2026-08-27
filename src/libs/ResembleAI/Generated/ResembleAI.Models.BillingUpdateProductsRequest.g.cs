
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUpdateProductsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.BillingProductQuantityChange> Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUpdateProductsRequest" /> class.
        /// </summary>
        /// <param name="changes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUpdateProductsRequest(
            global::System.Collections.Generic.IList<global::ResembleAI.BillingProductQuantityChange> changes)
        {
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUpdateProductsRequest" /> class.
        /// </summary>
        public BillingUpdateProductsRequest()
        {
        }

    }
}