
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Backward-compatible image/video verdict.
    /// </summary>
    public enum WatermarkVisionDetectionMetricsVerdict
    {
        /// <summary>
        ///
        /// </summary>
        Degraded,
        /// <summary>
        ///
        /// </summary>
        NotWatermarked,
        /// <summary>
        ///
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkVisionDetectionMetricsVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkVisionDetectionMetricsVerdict value)
        {
            return value switch
            {
                WatermarkVisionDetectionMetricsVerdict.Degraded => "degraded",
                WatermarkVisionDetectionMetricsVerdict.NotWatermarked => "not_watermarked",
                WatermarkVisionDetectionMetricsVerdict.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkVisionDetectionMetricsVerdict? ToEnum(string value)
        {
            return value switch
            {
                "degraded" => WatermarkVisionDetectionMetricsVerdict.Degraded,
                "not_watermarked" => WatermarkVisionDetectionMetricsVerdict.NotWatermarked,
                "verified" => WatermarkVisionDetectionMetricsVerdict.Verified,
                _ => null,
            };
        }
    }
}