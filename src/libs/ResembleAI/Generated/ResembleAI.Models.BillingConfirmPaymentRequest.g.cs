
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingConfirmPaymentRequest
    {
        /// <summary>
        /// Payment intent identifier completed by the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_intent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaymentIntentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingConfirmPaymentRequest" /> class.
        /// </summary>
        /// <param name="paymentIntentId">
        /// Payment intent identifier completed by the customer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingConfirmPaymentRequest(
            string paymentIntentId)
        {
            this.PaymentIntentId = paymentIntentId ?? throw new global::System.ArgumentNullException(nameof(paymentIntentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingConfirmPaymentRequest" /> class.
        /// </summary>
        public BillingConfirmPaymentRequest()
        {
        }

    }
}