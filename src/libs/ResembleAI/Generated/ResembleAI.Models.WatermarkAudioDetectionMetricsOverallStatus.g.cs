
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkAudioDetectionMetricsOverallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Absent,
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
    public static class WatermarkAudioDetectionMetricsOverallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkAudioDetectionMetricsOverallStatus value)
        {
            return value switch
            {
                WatermarkAudioDetectionMetricsOverallStatus.Absent => "absent",
                WatermarkAudioDetectionMetricsOverallStatus.Inconclusive => "inconclusive",
                WatermarkAudioDetectionMetricsOverallStatus.Present => "present",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkAudioDetectionMetricsOverallStatus? ToEnum(string value)
        {
            return value switch
            {
                "absent" => WatermarkAudioDetectionMetricsOverallStatus.Absent,
                "inconclusive" => WatermarkAudioDetectionMetricsOverallStatus.Inconclusive,
                "present" => WatermarkAudioDetectionMetricsOverallStatus.Present,
                _ => null,
            };
        }
    }
}