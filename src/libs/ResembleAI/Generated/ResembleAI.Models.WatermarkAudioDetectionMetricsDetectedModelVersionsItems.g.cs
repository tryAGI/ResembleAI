
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkAudioDetectionMetricsDetectedModelVersionsItems
    {
        /// <summary>
        ///
        /// </summary>
        PerthV1,
        /// <summary>
        ///
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkAudioDetectionMetricsDetectedModelVersionsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkAudioDetectionMetricsDetectedModelVersionsItems value)
        {
            return value switch
            {
                WatermarkAudioDetectionMetricsDetectedModelVersionsItems.PerthV1 => "perth_v1",
                WatermarkAudioDetectionMetricsDetectedModelVersionsItems.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkAudioDetectionMetricsDetectedModelVersionsItems? ToEnum(string value)
        {
            return value switch
            {
                "perth_v1" => WatermarkAudioDetectionMetricsDetectedModelVersionsItems.PerthV1,
                "perth_v2" => WatermarkAudioDetectionMetricsDetectedModelVersionsItems.PerthV2,
                _ => null,
            };
        }
    }
}