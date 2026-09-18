
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// `processing` until inference returns, `completed` once `prediction` and `confidence` are populated, or `failed` if the analysis errored.
    /// </summary>
    public enum TextDetectItemStatus
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
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDetectItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDetectItemStatus value)
        {
            return value switch
            {
                TextDetectItemStatus.Completed => "completed",
                TextDetectItemStatus.Failed => "failed",
                TextDetectItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDetectItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TextDetectItemStatus.Completed,
                "failed" => TextDetectItemStatus.Failed,
                "processing" => TextDetectItemStatus.Processing,
                _ => null,
            };
        }
    }
}