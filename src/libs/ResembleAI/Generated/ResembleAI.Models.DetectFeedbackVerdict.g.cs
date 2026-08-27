
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// What the model said, snapshotted when the feedback was submitted. `null` when the<br/>
    /// detection landed somewhere indeterminate. `should_be_neutral` and `should_be_non_ai`<br/>
    /// have no counterpart here — this field records only the two decided model outcomes.
    /// </summary>
    public enum DetectFeedbackVerdict
    {
        /// <summary>
        ///
        /// </summary>
        AiGenerated,
        /// <summary>
        ///
        /// </summary>
        Authentic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectFeedbackVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectFeedbackVerdict value)
        {
            return value switch
            {
                DetectFeedbackVerdict.AiGenerated => "ai_generated",
                DetectFeedbackVerdict.Authentic => "authentic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectFeedbackVerdict? ToEnum(string value)
        {
            return value switch
            {
                "ai_generated" => DetectFeedbackVerdict.AiGenerated,
                "authentic" => DetectFeedbackVerdict.Authentic,
                _ => null,
            };
        }
    }
}