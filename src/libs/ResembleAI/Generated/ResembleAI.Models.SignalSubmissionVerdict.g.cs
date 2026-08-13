
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SignalSubmissionVerdict
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
    public static class SignalSubmissionVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalSubmissionVerdict value)
        {
            return value switch
            {
                SignalSubmissionVerdict.Fraud => "fraud",
                SignalSubmissionVerdict.Safe => "safe",
                SignalSubmissionVerdict.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalSubmissionVerdict? ToEnum(string value)
        {
            return value switch
            {
                "fraud" => SignalSubmissionVerdict.Fraud,
                "safe" => SignalSubmissionVerdict.Safe,
                "suspicious" => SignalSubmissionVerdict.Suspicious,
                _ => null,
            };
        }
    }
}