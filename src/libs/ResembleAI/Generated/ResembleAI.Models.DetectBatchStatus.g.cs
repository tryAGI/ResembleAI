
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Aggregate status across all child detects.<br/>
    ///   - `processing` — at least one child detect is still running.<br/>
    ///   - `completed` — every child detect completed successfully.<br/>
    ///   - `partially_failed` — at least one succeeded and at least one failed.<br/>
    ///   - `failed` — every child detect failed.
    /// </summary>
    public enum DetectBatchStatus
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
        PartiallyFailed,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectBatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectBatchStatus value)
        {
            return value switch
            {
                DetectBatchStatus.Completed => "completed",
                DetectBatchStatus.Failed => "failed",
                DetectBatchStatus.PartiallyFailed => "partially_failed",
                DetectBatchStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectBatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectBatchStatus.Completed,
                "failed" => DetectBatchStatus.Failed,
                "partially_failed" => DetectBatchStatus.PartiallyFailed,
                "processing" => DetectBatchStatus.Processing,
                _ => null,
            };
        }
    }
}