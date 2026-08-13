
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingTransactionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.BillingWalletTransaction> Transactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::ResembleAI.BillingPagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTransactionsResponse" /> class.
        /// </summary>
        /// <param name="transactions"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingTransactionsResponse(
            global::System.Collections.Generic.IList<global::ResembleAI.BillingWalletTransaction> transactions,
            global::ResembleAI.BillingPagination? pagination)
        {
            this.Transactions = transactions ?? throw new global::System.ArgumentNullException(nameof(transactions));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTransactionsResponse" /> class.
        /// </summary>
        public BillingTransactionsResponse()
        {
        }

    }
}