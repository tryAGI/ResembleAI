
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingPlanBillingInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Annual,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Quarterly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingPlanBillingIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPlanBillingInterval value)
        {
            return value switch
            {
                BillingPlanBillingInterval.Annual => "annual",
                BillingPlanBillingInterval.Monthly => "monthly",
                BillingPlanBillingInterval.Quarterly => "quarterly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPlanBillingInterval? ToEnum(string value)
        {
            return value switch
            {
                "annual" => BillingPlanBillingInterval.Annual,
                "monthly" => BillingPlanBillingInterval.Monthly,
                "quarterly" => BillingPlanBillingInterval.Quarterly,
                _ => null,
            };
        }
    }
}