
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus
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
    public static class DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus value)
        {
            return value switch
            {
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Completed => "completed",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed => "failed",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Completed,
                "failed" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed,
                "processing" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing,
                _ => null,
            };
        }
    }
}