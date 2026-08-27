
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus
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
    public static class DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus value)
        {
            return value switch
            {
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Completed => "completed",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Failed => "failed",
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Completed,
                "failed" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Failed,
                "processing" => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceStatus.Processing,
                _ => null,
            };
        }
    }
}