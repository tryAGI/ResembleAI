
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkApplyItemModelVersion
    {
        /// <summary>
        ///
        /// </summary>
        PerthV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkApplyItemModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyItemModelVersion value)
        {
            return value switch
            {
                WatermarkApplyItemModelVersion.PerthV2 => "perth_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyItemModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "perth_v2" => WatermarkApplyItemModelVersion.PerthV2,
                _ => null,
            };
        }
    }
}