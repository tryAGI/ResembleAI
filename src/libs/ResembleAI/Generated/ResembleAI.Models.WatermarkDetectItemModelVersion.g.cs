
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Present for image/video. Audio versions are reported in metrics.model_results.
    /// </summary>
    public enum WatermarkDetectItemModelVersion
    {
        /// <summary>
        ///
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkDetectItemModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectItemModelVersion value)
        {
            return value switch
            {
                WatermarkDetectItemModelVersion.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectItemModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "perth_v2" => WatermarkDetectItemModelVersion.PerthV2,
                _ => null,
            };
        }
    }
}