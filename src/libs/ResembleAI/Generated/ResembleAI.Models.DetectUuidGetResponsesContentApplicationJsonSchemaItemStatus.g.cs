
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Status of the requested Deepfake Detection work. For an otherwise successful Detect with watermark analysis, processing continues until that nested analysis completes or fails. A core detection failure still reports failed. A failed watermark analysis is terminal and does not fail an otherwise successful deepfake detection. Intelligence may still be processing after Detect reaches completed.
    /// </summary>
    public enum DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus
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
    public static class DetectUuidGetResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "processing" => DetectUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}