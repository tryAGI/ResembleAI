
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingSubscriptionProductCategory
    {
        /// <summary>
        /// 
        /// </summary>
        BaseFee,
        /// <summary>
        /// 
        /// </summary>
        IncludedCredits,
        /// <summary>
        /// 
        /// </summary>
        Metered,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingSubscriptionProductCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingSubscriptionProductCategory value)
        {
            return value switch
            {
                BillingSubscriptionProductCategory.BaseFee => "base_fee",
                BillingSubscriptionProductCategory.IncludedCredits => "included_credits",
                BillingSubscriptionProductCategory.Metered => "metered",
                BillingSubscriptionProductCategory.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingSubscriptionProductCategory? ToEnum(string value)
        {
            return value switch
            {
                "base_fee" => BillingSubscriptionProductCategory.BaseFee,
                "included_credits" => BillingSubscriptionProductCategory.IncludedCredits,
                "metered" => BillingSubscriptionProductCategory.Metered,
                "subscription" => BillingSubscriptionProductCategory.Subscription,
                _ => null,
            };
        }
    }
}