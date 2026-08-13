
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingWalletTransactionTransactionType
    {
        /// <summary>
        /// 
        /// </summary>
        CreditPurchase,
        /// <summary>
        /// 
        /// </summary>
        ManualAdjustment,
        /// <summary>
        /// 
        /// </summary>
        PlanChange,
        /// <summary>
        /// 
        /// </summary>
        PlanSubscription,
        /// <summary>
        /// 
        /// </summary>
        PromotionBonus,
        /// <summary>
        /// 
        /// </summary>
        PromotionalCreditAdjustment,
        /// <summary>
        /// 
        /// </summary>
        Refund,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCancellation,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionRenewalCredit,
        /// <summary>
        /// 
        /// </summary>
        TrialCredit,
        /// <summary>
        /// 
        /// </summary>
        UsageDeduction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingWalletTransactionTransactionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingWalletTransactionTransactionType value)
        {
            return value switch
            {
                BillingWalletTransactionTransactionType.CreditPurchase => "credit_purchase",
                BillingWalletTransactionTransactionType.ManualAdjustment => "manual_adjustment",
                BillingWalletTransactionTransactionType.PlanChange => "plan_change",
                BillingWalletTransactionTransactionType.PlanSubscription => "plan_subscription",
                BillingWalletTransactionTransactionType.PromotionBonus => "promotion_bonus",
                BillingWalletTransactionTransactionType.PromotionalCreditAdjustment => "promotional_credit_adjustment",
                BillingWalletTransactionTransactionType.Refund => "refund",
                BillingWalletTransactionTransactionType.SubscriptionCancellation => "subscription_cancellation",
                BillingWalletTransactionTransactionType.SubscriptionRenewalCredit => "subscription_renewal_credit",
                BillingWalletTransactionTransactionType.TrialCredit => "trial_credit",
                BillingWalletTransactionTransactionType.UsageDeduction => "usage_deduction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingWalletTransactionTransactionType? ToEnum(string value)
        {
            return value switch
            {
                "credit_purchase" => BillingWalletTransactionTransactionType.CreditPurchase,
                "manual_adjustment" => BillingWalletTransactionTransactionType.ManualAdjustment,
                "plan_change" => BillingWalletTransactionTransactionType.PlanChange,
                "plan_subscription" => BillingWalletTransactionTransactionType.PlanSubscription,
                "promotion_bonus" => BillingWalletTransactionTransactionType.PromotionBonus,
                "promotional_credit_adjustment" => BillingWalletTransactionTransactionType.PromotionalCreditAdjustment,
                "refund" => BillingWalletTransactionTransactionType.Refund,
                "subscription_cancellation" => BillingWalletTransactionTransactionType.SubscriptionCancellation,
                "subscription_renewal_credit" => BillingWalletTransactionTransactionType.SubscriptionRenewalCredit,
                "trial_credit" => BillingWalletTransactionTransactionType.TrialCredit,
                "usage_deduction" => BillingWalletTransactionTransactionType.UsageDeduction,
                _ => null,
            };
        }
    }
}