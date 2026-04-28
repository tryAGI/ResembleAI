
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Processing status. Only "ready" pronunciations are applied during synthesis.
    /// </summary>
    public enum CustomPronunciationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPronunciationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPronunciationStatus value)
        {
            return value switch
            {
                CustomPronunciationStatus.Failed => "failed",
                CustomPronunciationStatus.Pending => "pending",
                CustomPronunciationStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPronunciationStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => CustomPronunciationStatus.Failed,
                "pending" => CustomPronunciationStatus.Pending,
                "ready" => CustomPronunciationStatus.Ready,
                _ => null,
            };
        }
    }
}