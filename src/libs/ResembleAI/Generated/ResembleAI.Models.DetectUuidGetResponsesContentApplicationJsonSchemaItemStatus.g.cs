
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Status of the Deepfake Detection job only. A completed Detect has verdict and metrics available, but its Intelligence results may still be processing.
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