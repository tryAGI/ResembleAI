
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Status of this Intelligence result, independent of the associated Detect job status.
    /// </summary>
    public enum DetectIntelligenceResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectIntelligenceResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectIntelligenceResultStatus value)
        {
            return value switch
            {
                DetectIntelligenceResultStatus.Completed => "completed",
                DetectIntelligenceResultStatus.Failed => "failed",
                DetectIntelligenceResultStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectIntelligenceResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectIntelligenceResultStatus.Completed,
                "failed" => DetectIntelligenceResultStatus.Failed,
                "processing" => DetectIntelligenceResultStatus.Processing,
                _ => null,
            };
        }
    }
}