
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkApplyItemOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        Apply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkApplyItemOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyItemOperationType value)
        {
            return value switch
            {
                WatermarkApplyItemOperationType.Apply => "apply",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyItemOperationType? ToEnum(string value)
        {
            return value switch
            {
                "apply" => WatermarkApplyItemOperationType.Apply,
                _ => null,
            };
        }
    }
}