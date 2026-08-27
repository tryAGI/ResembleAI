
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingWalletTransaction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.BillingWalletTransactionTransactionTypeJsonConverter))]
        public global::ResembleAI.BillingWalletTransactionTransactionType? TransactionType { get; set; }

        /// <summary>
        /// Positive for credits and negative for debits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_cents")]
        public double? AmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_after_cents")]
        public double? BalanceAfterCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletTransaction" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="transactionType"></param>
        /// <param name="amountCents">
        /// Positive for credits and negative for debits.
        /// </param>
        /// <param name="balanceAfterCents"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingWalletTransaction(
            long? id,
            global::ResembleAI.BillingWalletTransactionTransactionType? transactionType,
            double? amountCents,
            double? balanceAfterCents,
            string? description,
            object? metadata,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.TransactionType = transactionType;
            this.AmountCents = amountCents;
            this.BalanceAfterCents = balanceAfterCents;
            this.Description = description;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletTransaction" /> class.
        /// </summary>
        public BillingWalletTransaction()
        {
        }

    }
}