
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SignalScoreItemVerdict
    {
        /// <summary>
        /// 
        /// </summary>
        Fraud,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignalScoreItemVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalScoreItemVerdict value)
        {
            return value switch
            {
                SignalScoreItemVerdict.Fraud => "fraud",
                SignalScoreItemVerdict.Safe => "safe",
                SignalScoreItemVerdict.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalScoreItemVerdict? ToEnum(string value)
        {
            return value switch
            {
                "fraud" => SignalScoreItemVerdict.Fraud,
                "safe" => SignalScoreItemVerdict.Safe,
                "suspicious" => SignalScoreItemVerdict.Suspicious,
                _ => null,
            };
        }
    }
}