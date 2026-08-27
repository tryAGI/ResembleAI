
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingSubscriptionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        ActivePendingPayment,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Delinquent,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        PastDue,
        /// <summary>
        ///
        /// </summary>
        PendingPayment,
        /// <summary>
        ///
        /// </summary>
        Trialing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingSubscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingSubscriptionStatus value)
        {
            return value switch
            {
                BillingSubscriptionStatus.Active => "active",
                BillingSubscriptionStatus.ActivePendingPayment => "active_pending_payment",
                BillingSubscriptionStatus.Cancelled => "cancelled",
                BillingSubscriptionStatus.Delinquent => "delinquent",
                BillingSubscriptionStatus.Expired => "expired",
                BillingSubscriptionStatus.PastDue => "past_due",
                BillingSubscriptionStatus.PendingPayment => "pending_payment",
                BillingSubscriptionStatus.Trialing => "trialing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingSubscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BillingSubscriptionStatus.Active,
                "active_pending_payment" => BillingSubscriptionStatus.ActivePendingPayment,
                "cancelled" => BillingSubscriptionStatus.Cancelled,
                "delinquent" => BillingSubscriptionStatus.Delinquent,
                "expired" => BillingSubscriptionStatus.Expired,
                "past_due" => BillingSubscriptionStatus.PastDue,
                "pending_payment" => BillingSubscriptionStatus.PendingPayment,
                "trialing" => BillingSubscriptionStatus.Trialing,
                _ => null,
            };
        }
    }
}