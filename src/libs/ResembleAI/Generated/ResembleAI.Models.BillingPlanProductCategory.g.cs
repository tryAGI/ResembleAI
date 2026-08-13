
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingPlanProductCategory
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
    public static class BillingPlanProductCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPlanProductCategory value)
        {
            return value switch
            {
                BillingPlanProductCategory.BaseFee => "base_fee",
                BillingPlanProductCategory.IncludedCredits => "included_credits",
                BillingPlanProductCategory.Metered => "metered",
                BillingPlanProductCategory.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPlanProductCategory? ToEnum(string value)
        {
            return value switch
            {
                "base_fee" => BillingPlanProductCategory.BaseFee,
                "included_credits" => BillingPlanProductCategory.IncludedCredits,
                "metered" => BillingPlanProductCategory.Metered,
                "subscription" => BillingPlanProductCategory.Subscription,
                _ => null,
            };
        }
    }
}