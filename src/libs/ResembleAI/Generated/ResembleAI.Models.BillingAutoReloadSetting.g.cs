
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingAutoReloadSetting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reload_amount_cents")]
        public int? ReloadAmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reload_amount_dollars")]
        public double? ReloadAmountDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_balance_threshold_cents")]
        public int? MinimumBalanceThresholdCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_balance_threshold_dollars")]
        public double? MinimumBalanceThresholdDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_monthly_spend_cents")]
        public int? MaximumMonthlySpendCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_monthly_spend_dollars")]
        public double? MaximumMonthlySpendDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_month_spend_cents")]
        public int? CurrentMonthSpendCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_month_spend_dollars")]
        public double? CurrentMonthSpendDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_monthly_allowance_cents")]
        public int? RemainingMonthlyAllowanceCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_monthly_allowance_dollars")]
        public double? RemainingMonthlyAllowanceDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_method")]
        public bool? HasPaymentMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_reload")]
        public bool? CanReload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAutoReloadSetting" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="reloadAmountCents"></param>
        /// <param name="reloadAmountDollars"></param>
        /// <param name="minimumBalanceThresholdCents"></param>
        /// <param name="minimumBalanceThresholdDollars"></param>
        /// <param name="maximumMonthlySpendCents"></param>
        /// <param name="maximumMonthlySpendDollars"></param>
        /// <param name="currentMonthSpendCents"></param>
        /// <param name="currentMonthSpendDollars"></param>
        /// <param name="remainingMonthlyAllowanceCents"></param>
        /// <param name="remainingMonthlyAllowanceDollars"></param>
        /// <param name="hasPaymentMethod"></param>
        /// <param name="canReload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingAutoReloadSetting(
            bool? enabled,
            int? reloadAmountCents,
            double? reloadAmountDollars,
            int? minimumBalanceThresholdCents,
            double? minimumBalanceThresholdDollars,
            int? maximumMonthlySpendCents,
            double? maximumMonthlySpendDollars,
            int? currentMonthSpendCents,
            double? currentMonthSpendDollars,
            int? remainingMonthlyAllowanceCents,
            double? remainingMonthlyAllowanceDollars,
            bool? hasPaymentMethod,
            bool? canReload)
        {
            this.Enabled = enabled;
            this.ReloadAmountCents = reloadAmountCents;
            this.ReloadAmountDollars = reloadAmountDollars;
            this.MinimumBalanceThresholdCents = minimumBalanceThresholdCents;
            this.MinimumBalanceThresholdDollars = minimumBalanceThresholdDollars;
            this.MaximumMonthlySpendCents = maximumMonthlySpendCents;
            this.MaximumMonthlySpendDollars = maximumMonthlySpendDollars;
            this.CurrentMonthSpendCents = currentMonthSpendCents;
            this.CurrentMonthSpendDollars = currentMonthSpendDollars;
            this.RemainingMonthlyAllowanceCents = remainingMonthlyAllowanceCents;
            this.RemainingMonthlyAllowanceDollars = remainingMonthlyAllowanceDollars;
            this.HasPaymentMethod = hasPaymentMethod;
            this.CanReload = canReload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAutoReloadSetting" /> class.
        /// </summary>
        public BillingAutoReloadSetting()
        {
        }

    }
}