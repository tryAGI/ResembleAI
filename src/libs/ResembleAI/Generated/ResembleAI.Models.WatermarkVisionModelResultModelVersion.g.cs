
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkVisionModelResultModelVersion
    {
        /// <summary>
        ///
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkVisionModelResultModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkVisionModelResultModelVersion value)
        {
            return value switch
            {
                WatermarkVisionModelResultModelVersion.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkVisionModelResultModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "perth_v2" => WatermarkVisionModelResultModelVersion.PerthV2,
                _ => null,
            };
        }
    }
}