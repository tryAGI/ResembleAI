
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectAgentRunSummaryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectAgentRunSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectAgentRunSummaryStatus value)
        {
            return value switch
            {
                DetectAgentRunSummaryStatus.Completed => "completed",
                DetectAgentRunSummaryStatus.Error => "error",
                DetectAgentRunSummaryStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectAgentRunSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectAgentRunSummaryStatus.Completed,
                "error" => DetectAgentRunSummaryStatus.Error,
                "running" => DetectAgentRunSummaryStatus.Running,
                _ => null,
            };
        }
    }
}