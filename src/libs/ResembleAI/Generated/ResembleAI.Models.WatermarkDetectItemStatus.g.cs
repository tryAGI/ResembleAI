
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkDetectItemStatus
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
    public static class WatermarkDetectItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectItemStatus value)
        {
            return value switch
            {
                WatermarkDetectItemStatus.Completed => "completed",
                WatermarkDetectItemStatus.Failed => "failed",
                WatermarkDetectItemStatus.Pending => "pending",
                WatermarkDetectItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WatermarkDetectItemStatus.Completed,
                "failed" => WatermarkDetectItemStatus.Failed,
                "pending" => WatermarkDetectItemStatus.Pending,
                "processing" => WatermarkDetectItemStatus.Processing,
                _ => null,
            };
        }
    }
}