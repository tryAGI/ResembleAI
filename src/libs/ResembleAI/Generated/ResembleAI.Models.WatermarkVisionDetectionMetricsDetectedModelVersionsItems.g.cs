
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkVisionDetectionMetricsDetectedModelVersionsItems
    {
        /// <summary>
        /// 
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkVisionDetectionMetricsDetectedModelVersionsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkVisionDetectionMetricsDetectedModelVersionsItems value)
        {
            return value switch
            {
                WatermarkVisionDetectionMetricsDetectedModelVersionsItems.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkVisionDetectionMetricsDetectedModelVersionsItems? ToEnum(string value)
        {
            return value switch
            {
                "perth_v2" => WatermarkVisionDetectionMetricsDetectedModelVersionsItems.PerthV2,
                _ => null,
            };
        }
    }
}