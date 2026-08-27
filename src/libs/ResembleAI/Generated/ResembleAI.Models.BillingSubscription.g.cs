
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingSubscription
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::ResembleAI.BillingPlan? Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingSubscriptionStatusJsonConverter))]
        public global::ResembleAI.BillingSubscriptionStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_period_start")]
        public global::System.DateTime? CurrentPeriodStart { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_period_end")]
        public global::System.DateTime? CurrentPeriodEnd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at_period_end")]
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at")]
        public global::System.DateTime? CancelAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activated_at")]
        public global::System.DateTime? ActivatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_due_date")]
        public global::System.DateTime? InvoiceDueDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delinquent_at")]
        public global::System.DateTime? DelinquentAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.BillingSubscriptionItem>? SubscriptionItems { get; set; }

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
        /// Initializes a new instance of the <see cref="BillingSubscription" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="plan"></param>
        /// <param name="status"></param>
        /// <param name="currentPeriodStart"></param>
        /// <param name="currentPeriodEnd"></param>
        /// <param name="cancelAtPeriodEnd"></param>
        /// <param name="cancelAt"></param>
        /// <param name="activatedAt"></param>
        /// <param name="invoiceDueDate"></param>
        /// <param name="delinquentAt"></param>
        /// <param name="subscriptionItems"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingSubscription(
            long? id,
            global::ResembleAI.BillingPlan? plan,
            global::ResembleAI.BillingSubscriptionStatus? status,
            global::System.DateTime? currentPeriodStart,
            global::System.DateTime? currentPeriodEnd,
            bool? cancelAtPeriodEnd,
            global::System.DateTime? cancelAt,
            global::System.DateTime? activatedAt,
            global::System.DateTime? invoiceDueDate,
            global::System.DateTime? delinquentAt,
            global::System.Collections.Generic.IList<global::ResembleAI.BillingSubscriptionItem>? subscriptionItems,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Plan = plan;
            this.Status = status;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CancelAt = cancelAt;
            this.ActivatedAt = activatedAt;
            this.InvoiceDueDate = invoiceDueDate;
            this.DelinquentAt = delinquentAt;
            this.SubscriptionItems = subscriptionItems;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscription" /> class.
        /// </summary>
        public BillingSubscription()
        {
        }

    }
}