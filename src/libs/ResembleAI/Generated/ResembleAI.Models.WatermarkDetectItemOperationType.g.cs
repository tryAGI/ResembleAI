
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkDetectItemOperationType
    {
        /// <summary>
        ///
        /// </summary>
        Detect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkDetectItemOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectItemOperationType value)
        {
            return value switch
            {
                WatermarkDetectItemOperationType.Detect => "detect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectItemOperationType? ToEnum(string value)
        {
            return value switch
            {
                "detect" => WatermarkDetectItemOperationType.Detect,
                _ => null,
            };
        }
    }
}