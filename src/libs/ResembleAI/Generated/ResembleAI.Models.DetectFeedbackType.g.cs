
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// What the verdict should have been.
    /// </summary>
    public enum DetectFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        Correct,
        /// <summary>
        /// 
        /// </summary>
        ShouldBeAiGenerated,
        /// <summary>
        /// 
        /// </summary>
        ShouldBeAuthentic,
        /// <summary>
        /// 
        /// </summary>
        ShouldBeNeutral,
        /// <summary>
        /// 
        /// </summary>
        ShouldBeNonAi,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectFeedbackType value)
        {
            return value switch
            {
                DetectFeedbackType.Correct => "correct",
                DetectFeedbackType.ShouldBeAiGenerated => "should_be_ai_generated",
                DetectFeedbackType.ShouldBeAuthentic => "should_be_authentic",
                DetectFeedbackType.ShouldBeNeutral => "should_be_neutral",
                DetectFeedbackType.ShouldBeNonAi => "should_be_non_ai",
                DetectFeedbackType.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "correct" => DetectFeedbackType.Correct,
                "should_be_ai_generated" => DetectFeedbackType.ShouldBeAiGenerated,
                "should_be_authentic" => DetectFeedbackType.ShouldBeAuthentic,
                "should_be_neutral" => DetectFeedbackType.ShouldBeNeutral,
                "should_be_non_ai" => DetectFeedbackType.ShouldBeNonAi,
                "skipped" => DetectFeedbackType.Skipped,
                _ => null,
            };
        }
    }
}