
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Lifecycle state of the linked watermark analysis.
    /// </summary>
    public enum DetectWatermarkAnalysisStatus
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
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectWatermarkAnalysisStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectWatermarkAnalysisStatus value)
        {
            return value switch
            {
                DetectWatermarkAnalysisStatus.Completed => "completed",
                DetectWatermarkAnalysisStatus.Failed => "failed",
                DetectWatermarkAnalysisStatus.Pending => "pending",
                DetectWatermarkAnalysisStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectWatermarkAnalysisStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectWatermarkAnalysisStatus.Completed,
                "failed" => DetectWatermarkAnalysisStatus.Failed,
                "pending" => DetectWatermarkAnalysisStatus.Pending,
                "processing" => DetectWatermarkAnalysisStatus.Processing,
                _ => null,
            };
        }
    }
}