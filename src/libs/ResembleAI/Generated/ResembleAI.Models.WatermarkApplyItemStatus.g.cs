
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkApplyItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkApplyItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyItemStatus value)
        {
            return value switch
            {
                WatermarkApplyItemStatus.Completed => "completed",
                WatermarkApplyItemStatus.Failed => "failed",
                WatermarkApplyItemStatus.Pending => "pending",
                WatermarkApplyItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WatermarkApplyItemStatus.Completed,
                "failed" => WatermarkApplyItemStatus.Failed,
                "pending" => WatermarkApplyItemStatus.Pending,
                "processing" => WatermarkApplyItemStatus.Processing,
                _ => null,
            };
        }
    }
}