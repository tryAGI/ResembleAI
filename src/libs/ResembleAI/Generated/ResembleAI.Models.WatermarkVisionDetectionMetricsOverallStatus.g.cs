
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkVisionDetectionMetricsOverallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Absent,
        /// <summary>
        ///
        /// </summary>
        Degraded,
        /// <summary>
        ///
        /// </summary>
        Inconclusive,
        /// <summary>
        ///
        /// </summary>
        Present,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkVisionDetectionMetricsOverallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkVisionDetectionMetricsOverallStatus value)
        {
            return value switch
            {
                WatermarkVisionDetectionMetricsOverallStatus.Absent => "absent",
                WatermarkVisionDetectionMetricsOverallStatus.Degraded => "degraded",
                WatermarkVisionDetectionMetricsOverallStatus.Inconclusive => "inconclusive",
                WatermarkVisionDetectionMetricsOverallStatus.Present => "present",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkVisionDetectionMetricsOverallStatus? ToEnum(string value)
        {
            return value switch
            {
                "absent" => WatermarkVisionDetectionMetricsOverallStatus.Absent,
                "degraded" => WatermarkVisionDetectionMetricsOverallStatus.Degraded,
                "inconclusive" => WatermarkVisionDetectionMetricsOverallStatus.Inconclusive,
                "present" => WatermarkVisionDetectionMetricsOverallStatus.Present,
                _ => null,
            };
        }
    }
}