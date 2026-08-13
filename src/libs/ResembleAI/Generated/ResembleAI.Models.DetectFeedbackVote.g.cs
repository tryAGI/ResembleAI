
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Derived from `type` — `correct` is `up`, everything else is `down`. Never independent of `type`.
    /// </summary>
    public enum DetectFeedbackVote
    {
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectFeedbackVoteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectFeedbackVote value)
        {
            return value switch
            {
                DetectFeedbackVote.Down => "down",
                DetectFeedbackVote.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectFeedbackVote? ToEnum(string value)
        {
            return value switch
            {
                "down" => DetectFeedbackVote.Down,
                "up" => DetectFeedbackVote.Up,
                _ => null,
            };
        }
    }
}