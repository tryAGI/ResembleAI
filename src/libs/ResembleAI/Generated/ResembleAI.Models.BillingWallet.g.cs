
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingWallet
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_cents")]
        public double? BalanceCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_dollars")]
        public double? BalanceDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cash_balance_cents")]
        public double? CashBalanceCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cash_balance_dollars")]
        public double? CashBalanceDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotional_balance_cents")]
        public double? PromotionalBalanceCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotional_balance_dollars")]
        public double? PromotionalBalanceDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetime_loaded_cents")]
        public double? LifetimeLoadedCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetime_loaded_dollars")]
        public double? LifetimeLoadedDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetime_consumed_cents")]
        public double? LifetimeConsumedCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetime_consumed_dollars")]
        public double? LifetimeConsumedDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_balance")]
        public bool? LowBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWallet" /> class.
        /// </summary>
        /// <param name="balanceCents"></param>
        /// <param name="balanceDollars"></param>
        /// <param name="cashBalanceCents"></param>
        /// <param name="cashBalanceDollars"></param>
        /// <param name="promotionalBalanceCents"></param>
        /// <param name="promotionalBalanceDollars"></param>
        /// <param name="lifetimeLoadedCents"></param>
        /// <param name="lifetimeLoadedDollars"></param>
        /// <param name="lifetimeConsumedCents"></param>
        /// <param name="lifetimeConsumedDollars"></param>
        /// <param name="lowBalance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingWallet(
            double? balanceCents,
            double? balanceDollars,
            double? cashBalanceCents,
            double? cashBalanceDollars,
            double? promotionalBalanceCents,
            double? promotionalBalanceDollars,
            double? lifetimeLoadedCents,
            double? lifetimeLoadedDollars,
            double? lifetimeConsumedCents,
            double? lifetimeConsumedDollars,
            bool? lowBalance)
        {
            this.BalanceCents = balanceCents;
            this.BalanceDollars = balanceDollars;
            this.CashBalanceCents = cashBalanceCents;
            this.CashBalanceDollars = cashBalanceDollars;
            this.PromotionalBalanceCents = promotionalBalanceCents;
            this.PromotionalBalanceDollars = promotionalBalanceDollars;
            this.LifetimeLoadedCents = lifetimeLoadedCents;
            this.LifetimeLoadedDollars = lifetimeLoadedDollars;
            this.LifetimeConsumedCents = lifetimeConsumedCents;
            this.LifetimeConsumedDollars = lifetimeConsumedDollars;
            this.LowBalance = lowBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWallet" /> class.
        /// </summary>
        public BillingWallet()
        {
        }

    }
}