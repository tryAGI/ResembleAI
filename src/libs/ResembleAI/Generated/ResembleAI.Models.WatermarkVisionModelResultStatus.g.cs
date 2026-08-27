
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkVisionModelResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkVisionModelResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkVisionModelResultStatus value)
        {
            return value switch
            {
                WatermarkVisionModelResultStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkVisionModelResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "succeeded" => WatermarkVisionModelResultStatus.Succeeded,
                _ => null,
            };
        }
    }
}