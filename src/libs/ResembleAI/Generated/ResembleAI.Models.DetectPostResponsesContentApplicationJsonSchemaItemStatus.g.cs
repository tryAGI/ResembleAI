
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Processing state for the requested Detect work. For an otherwise successful Detect with watermark analysis, this remains processing until the linked analysis completes or fails. A core detection failure still reports failed.
    /// </summary>
    public enum DetectPostResponsesContentApplicationJsonSchemaItemStatus
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
    public static class DetectPostResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                DetectPostResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                DetectPostResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                DetectPostResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectPostResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => DetectPostResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "processing" => DetectPostResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}