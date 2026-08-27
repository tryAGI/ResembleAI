
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUpdateAutoReloadRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reload_amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReloadAmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_balance_threshold_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinimumBalanceThresholdCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_monthly_spend_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaximumMonthlySpendCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUpdateAutoReloadRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="reloadAmountCents"></param>
        /// <param name="minimumBalanceThresholdCents"></param>
        /// <param name="maximumMonthlySpendCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUpdateAutoReloadRequest(
            bool enabled,
            int reloadAmountCents,
            int minimumBalanceThresholdCents,
            int maximumMonthlySpendCents)
        {
            this.Enabled = enabled;
            this.ReloadAmountCents = reloadAmountCents;
            this.MinimumBalanceThresholdCents = minimumBalanceThresholdCents;
            this.MaximumMonthlySpendCents = maximumMonthlySpendCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUpdateAutoReloadRequest" /> class.
        /// </summary>
        public BillingUpdateAutoReloadRequest()
        {
        }

    }
}