
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingPlanPlanType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        SelfServe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingPlanPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPlanPlanType value)
        {
            return value switch
            {
                BillingPlanPlanType.Custom => "custom",
                BillingPlanPlanType.Default => "default",
                BillingPlanPlanType.SelfServe => "self_serve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPlanPlanType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BillingPlanPlanType.Custom,
                "default" => BillingPlanPlanType.Default,
                "self_serve" => BillingPlanPlanType.SelfServe,
                _ => null,
            };
        }
    }
}